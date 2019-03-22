using System;
using System.Collections.Generic;
using System.Text;
using Apteco.ApiSystemAnalyser.ApiClient.Api;
using Apteco.ApiSystemAnalyser.ApiClient.Model;

namespace Apteco.ApiSystemAnalyser.Core
{
  public interface IApiConnectorFactory
  {
    #region public methods
    ISessionsApi CreateSessionsApi(SessionDetails sessionDetails);
    IFastStatsSystemsApi CreateFastStatsSystemsApi(SessionDetails sessionDetails);
    #endregion
  }
}
