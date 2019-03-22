using System.Linq;
using System.Threading.Tasks;
using Apteco.ApiSystemAnalyser.ApiClient.Model;
using Apteco.ApiSystemAnalyser.Core;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;

namespace Apteco.ApiSystemAnalyser.Console
{
  class Program
  {
    private static int Main(string[] args)
    {
      if (args == null || args.Length < 4)
      {
        System.Console.WriteLine("Usage: ApiSystemAnalyser-Console.exe <Orbit API base URL> <DataView name> <username> <password>");
        return 0;
      }

      Task<int> task = Task.Run(() => Run(args[0], args[1], args[2], args[3]));
      task.Wait();
      return task.Result;
    }

    private static async Task<int> Run(string baseUrl, string dataViewName, string username, string password)
    {
      LoggerFactory loggerFactory = CreateLoggerFactory();
      ILogger<Program> logger = loggerFactory.CreateLogger<Program>();

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
        StatsGatherer statsGatherer = new StatsGatherer(connectorFactory, dataViewName, loggerFactory.CreateLogger<StatsGatherer>());
        bool success = await statsGatherer.OutputStats(sessionDetails, System.Console.Out);
        return success ? 0 : -1;
      }
      finally
      {
        await loginService.Logout(sessionDetails);
      }
    }

    private static LoggerFactory CreateLoggerFactory()
    {
      var configureNamedOptions = new ConfigureNamedOptions<ConsoleLoggerOptions>("", null);
      var optionsFactory = new OptionsFactory<ConsoleLoggerOptions>(new[] { configureNamedOptions }, Enumerable.Empty<IPostConfigureOptions<ConsoleLoggerOptions>>());
      var optionsMonitor = new OptionsMonitor<ConsoleLoggerOptions>(optionsFactory, Enumerable.Empty<IOptionsChangeTokenSource<ConsoleLoggerOptions>>(), new OptionsCache<ConsoleLoggerOptions>());
      return new LoggerFactory(new[] { new ConsoleLoggerProvider(optionsMonitor) }, new LoggerFilterOptions { MinLevel = LogLevel.Information });
    }
  }
}
