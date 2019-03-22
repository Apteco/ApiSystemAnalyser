using System;
using System.Collections.Generic;
using Apteco.ApiSystemAnalyser.ApiClient.Api;
using Apteco.ApiSystemAnalyser.ApiClient.Client;
using Apteco.ApiSystemAnalyser.ApiClient.Model;

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
    public IAboutApi CreateAboutApi(SessionDetails sessionDetails)
    {
      return new AboutApi(CreateConfiguration(sessionDetails));
    }

    public ISessionsApi CreateSessionsApi(SessionDetails sessionDetails)
    {
      return new SessionsApi(CreateConfiguration(sessionDetails));
    }

    public IFastStatsSystemsApi CreateFastStatsSystemsApi(SessionDetails sessionDetails)
    {
      return new FastStatsSystemsApi(CreateConfiguration(sessionDetails));
    }
    #endregion

    #region private methods
    private Configuration CreateConfiguration(SessionDetails sessionDetails)
    {
      Dictionary<string, string> defaultHeaders = new Dictionary<string, string>();
      if (sessionDetails != null)
      {
        defaultHeaders.Add("Authorization", "Bearer " + sessionDetails.AccessToken);
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
