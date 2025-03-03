using System.Collections.Generic;
using Apteco.ApiSystemAnalyser.ApiClient.Api;
using Apteco.ApiSystemAnalyser.ApiClient.Client;

namespace Apteco.ApiSystemAnalyser.Core.Services
{
  public class ApiConnectorFactory : IApiConnectorFactory
  {
    #region private fields
    private string baseUrl;
    #endregion

    #region public constructor
    public ApiConnectorFactory(string baseUrl)
    {
      this.baseUrl = baseUrl;
    }
    #endregion

    #region public methods
    public IAboutApi CreateAboutApi(string accessToken)
    {
      return new AboutApi(CreateConfiguration(accessToken));
    }

    public ISessionsApi CreateSessionsApi(string accessToken)
    {
      return new SessionsApi(CreateConfiguration(accessToken));
    }

    public IFastStatsSystemsApi CreateFastStatsSystemsApi(string accessToken)
    {
      return new FastStatsSystemsApi(CreateConfiguration(accessToken));
    }
    #endregion

    #region private methods
    private Configuration CreateConfiguration(string accessToken)
    {
      Dictionary<string, string> defaultHeaders = new Dictionary<string, string>();
      if (accessToken != null)
      {
        defaultHeaders.Add("Authorization", "Bearer " + accessToken);
      }

      return new Configuration()
      {
        DefaultHeader = defaultHeaders,
        BasePath = baseUrl
      };
    }
    #endregion
  }
}
