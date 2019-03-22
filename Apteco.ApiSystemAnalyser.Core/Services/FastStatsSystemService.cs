using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apteco.ApiSystemAnalyser.ApiClient.Api;
using Apteco.ApiSystemAnalyser.ApiClient.Model;
using Apteco.ApiSystemAnalyser.Core.Utilities;

namespace Apteco.ApiSystemAnalyser.Core.Services
{
  public class FastStatsSystemService
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    #endregion

    #region public constructor
    public FastStatsSystemService(IApiConnectorFactory connectorFactory, string dataViewName)
    {
      this.connectorFactory = connectorFactory;
      this.dataViewName = dataViewName;
    }
    #endregion

    #region public methods
    public async Task<List<string>> GetSystemNames(SessionDetails sessionDetails)
    {
      IFastStatsSystemsApi systemApi = connectorFactory.CreateFastStatsSystemsApi(sessionDetails);
      PagedResultsFastStatsSystemSummary systems = await systemApi.FastStatsSystemsGetFastStatsSystemsAsync(dataViewName, null, null, null, 1000);
      return systems?.List?.Select(s => s.Name).ToList() ?? new List<string>();
    }

    public async Task<VariableStatistics> GetVariableStatistics(string systemName, SessionDetails sessionDetails)
    {
      IFastStatsSystemsApi systemApi = connectorFactory.CreateFastStatsSystemsApi(sessionDetails);
      PagedResultsVariable variables = await systemApi.FastStatsSystemsGetFastStatsVariablesAsync(dataViewName, systemName, null, null, null, 1000000);

      VariableStatistics variableStatistics = new VariableStatistics();
      variableStatistics.SystemName = systemName;

      List<double> numberOfCodesList = new List<double>();
      List<double> totalCodeSizeList = new List<double>();
      foreach (Variable variable in variables.List)
      {
        variableStatistics.NumberOfVariables++;

        if (variable.SelectorInfo != null)
        {
          int numberOfCodes = variable.SelectorInfo.NumberOfCodes ?? 0;

          variableStatistics.NumberOfSelectors++;
          numberOfCodesList.Add(numberOfCodes);
          totalCodeSizeList.Add(numberOfCodes * variable.SelectorInfo.CodeLength ?? 0);
        }
      }

      variableStatistics.TotalNumberOfVarCodes = (int)numberOfCodesList.Sum();
      variableStatistics.MedianCodesPerVariable = DistributionUtilities.GetMedian(numberOfCodesList);
      variableStatistics.TotalCodeSize = (long)totalCodeSizeList.Sum();
      variableStatistics.MedianCodeSizePerVariable = DistributionUtilities.GetMedian(totalCodeSizeList);
      return variableStatistics;
    }
    #endregion
  }
}
