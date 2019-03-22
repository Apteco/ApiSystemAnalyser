using Apteco.ApiSystemAnalyser.ApiClient.Api;
using Apteco.ApiSystemAnalyser.ApiClient.Model;

namespace Apteco.ApiSystemAnalyser.Core.Services
{
  public interface IApiConnectorFactory
  {
    #region public methods
    IAboutApi CreateAboutApi(SessionDetails sessionDetails);
    ISessionsApi CreateSessionsApi(SessionDetails sessionDetails);
    IFastStatsSystemsApi CreateFastStatsSystemsApi(SessionDetails sessionDetails);
    #endregion
  }
}
