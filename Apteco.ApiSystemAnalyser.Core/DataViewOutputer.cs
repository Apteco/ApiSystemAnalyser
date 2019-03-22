using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Apteco.ApiSystemAnalyser.ApiClient.Model;
using Apteco.ApiSystemAnalyser.Core.Services;
using Microsoft.Extensions.Logging;

namespace Apteco.ApiSystemAnalyser.Core
{
  public class DataViewOutputer
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private ILogger<DataViewOutputer> logger;
    #endregion

    #region public constructor
    public DataViewOutputer(IApiConnectorFactory connectorFactory, ILogger<DataViewOutputer> logger)
    {
      this.connectorFactory = connectorFactory;
      this.logger = logger;
    }
    #endregion

    #region public methods
    public async Task<bool> OutputDataViews(TextWriter outputWriter)
    {
      DataViewService dataViewService = new DataViewService(connectorFactory);
      List<DataViewDetails> dataViews = await dataViewService.GetAvailableDataViews();
      if (dataViews == null)
      {
        logger.LogInformation("Can't get dataviews from the API");
        return false;
      }

      outputWriter.WriteLine("DataView names:");
      foreach (DataViewDetails dataView in dataViews)
      {
        outputWriter.WriteLine(dataView.Name);
      }
      return true;
    }
    #endregion
  }
}
