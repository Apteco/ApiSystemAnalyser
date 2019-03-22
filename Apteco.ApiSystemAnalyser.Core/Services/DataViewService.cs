using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Apteco.ApiSystemAnalyser.ApiClient.Api;
using Apteco.ApiSystemAnalyser.ApiClient.Client;
using Apteco.ApiSystemAnalyser.ApiClient.Model;

namespace Apteco.ApiSystemAnalyser.Core.Services
{
  public class DataViewService
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    #endregion

    #region public constructor
    public DataViewService(IApiConnectorFactory connectorFactory)
    {
      this.connectorFactory = connectorFactory;
    }
    #endregion

    #region public methods
    public async Task<List<DataViewDetails>> GetAvailableDataViews()
    {
      IAboutApi aboutApi = connectorFactory.CreateAboutApi(null);
      ApiResponse<PagedResultsDataViewDetails> dataViewsResponse;
      try
      {
        dataViewsResponse = await aboutApi.AboutGetDataViewsAsyncWithHttpInfo(null, null, null, 1000);
        if (dataViewsResponse?.StatusCode != 200)
          return null;
      }
      catch (ApiException)
      {
        return null;
      }

      return dataViewsResponse?.Data?.List ?? new List<DataViewDetails>();
    }
    #endregion
  }
}
