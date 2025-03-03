using System;
using System.Threading.Tasks;
using Apteco.ApiSystemAnalyser.ApiClient.Model;
using Apteco.ApiSystemAnalyser.Core;
using Apteco.ApiSystemAnalyser.Core.Services;
using Microsoft.Extensions.Logging;

namespace Apteco.ApiSystemAnalyser.Console
{
  class Program
  {
    private static int Main(string[] args)
    {
      if (args == null || args.Length < 1)
      {
        return OutputUsage();
      }

      if (args.Length == 1)
      {
        Task<int> task = Task.Run(() => OutputDataViews(args[0]));
        task.Wait();
        return task.Result;
      }
      else if (args.Length == 3)
      {
        Task<int> task = Task.Run(() => OutputStats(args[0], args[1], args[2]));
        task.Wait();
        return task.Result;
      }
      else if (args.Length >= 4)
      {
        Task<int> task = Task.Run(() => LoginAndOutputStats(args[0], args[1], args[2], args[3]));
        task.Wait();
        return task.Result;
      }
      else
      {
        return OutputUsage();
      }
    }

    private static int OutputUsage()
    {
      string usageString =
        "Usage:" + Environment.NewLine +
        "  ApiSystemAnalyser-Console.exe <Orbit API base URL>" + Environment.NewLine +
        "  ApiSystemAnalyser-Console.exe <Orbit API base URL> <DataView name> <token>" + Environment.NewLine +
        "  ApiSystemAnalyser-Console.exe <Orbit API base URL> <DataView name> <username> <password>" + Environment.NewLine +
        Environment.NewLine +
        "  If only the API base URL is specified then the system analyser will try and list all the available DataViews." + Environment.NewLine +
        "  Note that the API may be configured to not allow these to be listed." + Environment.NewLine +
        Environment.NewLine +
        "  If the DataView and an access token are supplied then statistics for all systems in the specified DataView are output" + Environment.NewLine +
        "  If the DataView, username and password are supplied then the tool will log in and then statistics for all systems in the specified DataView are output" + Environment.NewLine;

      System.Console.WriteLine(usageString);
      return 0;
    }

    private static async Task<int> OutputDataViews(string baseUrl)
    {
      using (LoggingHandler loggingHandler = new LoggingHandler())
      {
        ApiConnectorFactory connectorFactory = new ApiConnectorFactory(baseUrl);

        DataViewOutputer dataViewOutputer = new DataViewOutputer(connectorFactory, loggingHandler.CreateLogger<DataViewOutputer>());
        bool success = await dataViewOutputer.OutputDataViews(System.Console.Out);
        return success ? 0 : -1;
      }
    }

    private static async Task<int> LoginAndOutputStats(string baseUrl, string dataViewName, string username, string password)
    {
      using (LoggingHandler loggingHandler = new LoggingHandler())
      {
        ILogger<Program> logger = loggingHandler.CreateLogger<Program>();

        ApiConnectorFactory connectorFactory = new ApiConnectorFactory(baseUrl);
        LoginService loginService = new LoginService(connectorFactory, dataViewName);

        SessionDetails sessionDetails = await loginService.Login(username, password);
        if (sessionDetails == null)
        {
          logger.LogError($"Couldn't log in to data view {dataViewName} as user {username}");
          return -1;
        }

        try
        {
          return await OutputStats(loggingHandler, connectorFactory, baseUrl, dataViewName, sessionDetails.AccessToken);
        }
        finally
        {
          await loginService.Logout(sessionDetails);
        }
      }
    }

    private static async Task<int> OutputStats(string baseUrl, string dataViewName, string accessToken)
    {
      using (LoggingHandler loggingHandler = new LoggingHandler())
      {
        ILogger<Program> logger = loggingHandler.CreateLogger<Program>();
        ApiConnectorFactory connectorFactory = new ApiConnectorFactory(baseUrl);

        return await OutputStats(loggingHandler, connectorFactory, baseUrl, dataViewName, accessToken);
      }
    }

    private static async Task<int> OutputStats(LoggingHandler loggingHandler, ApiConnectorFactory connectorFactory, string baseUrl, string dataViewName, string accessToken)
    {
      StatsGatherer statsGatherer = new StatsGatherer(connectorFactory, dataViewName, loggingHandler.CreateLogger<StatsGatherer>());
      bool success = await statsGatherer.OutputStats(accessToken, System.Console.Out);
      return success ? 0 : -1;
    }
  }
}
