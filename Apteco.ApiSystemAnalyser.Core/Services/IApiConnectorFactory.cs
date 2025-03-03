using Apteco.ApiSystemAnalyser.ApiClient.Api;
using Apteco.ApiSystemAnalyser.ApiClient.Model;

namespace Apteco.ApiSystemAnalyser.Core.Services
{
  public interface IApiConnectorFactory
  {
    #region public methods
    IAboutApi CreateAboutApi(string accessToken);
    ISessionsApi CreateSessionsApi(string accessToken);
    IFastStatsSystemsApi CreateFastStatsSystemsApi(string accessToken);
    #endregion
  }
}
