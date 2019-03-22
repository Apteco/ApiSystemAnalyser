using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Apteco.ApiSystemAnalyser.ApiClient.Model;
using Microsoft.Extensions.Logging;

namespace Apteco.ApiSystemAnalyser.Core
{
  public class StatsGatherer
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    private ILogger<StatsGatherer> logger;
    #endregion

    #region public constructor
    public StatsGatherer(IApiConnectorFactory connectorFactory, string dataViewName, ILogger<StatsGatherer> logger)
    {
      this.dataViewName = dataViewName;
      this.connectorFactory = connectorFactory;
      this.logger = logger;
    }
    #endregion

    #region public methods
    public async Task<bool> OutputStats(SessionDetails sessionDetails, TextWriter outputWriter)
    {
      FastStatsSystemService fastStatsSystemService = new FastStatsSystemService(connectorFactory, dataViewName);
      List<string> systemNames = await fastStatsSystemService.GetSystemNames(sessionDetails);

      if (systemNames == null || systemNames.Count == 0)
      {
        logger.LogError($"Couldn't find any FastStats systems in data view {dataViewName}");
        return false;
      }

      foreach (string systemName in systemNames)
      {
        VariableStatistics stats = await fastStatsSystemService.GetVariableStatistics(systemName, sessionDetails);
        outputWriter.WriteLine(stats);
        outputWriter.WriteLine();
        outputWriter.WriteLine();
      }

      return true;
    }
    #endregion
  }
}
