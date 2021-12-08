using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasabi.Wacm.SDK.Abstractions.Internals;
using Wasabi.Wacm.SDK.Configuration;
using Wasabi.Wacm.SDK.Exceptions;

namespace Wasabi.Wacm.SDK.Services
{
    internal class EndpointsFactory : IEndpointsFactory
    {
        public string GetListAccountsUrl() => WacmContext.Options.WacmVersion switch
        {
            WacmVersions.VERSION_1 => Endpoints.V1.Accounts.List,
            _ => throw new InvalidWacmVersionException(WacmContext.Options.WacmVersion)
        };

        public string GetCreateAccountUrl() => WacmContext.Options.WacmVersion switch
        {
            WacmVersions.VERSION_1 => Endpoints.V1.Accounts.Create,
            _ => throw new InvalidWacmVersionException(WacmContext.Options.WacmVersion)
        };

        public string GetUpdateAccountUrl(int accountNumber) => WacmContext.Options.WacmVersion switch
        {
            WacmVersions.VERSION_1 => Endpoints.V1.Accounts.Update.Replace(UrlVariables.AccountNumber, accountNumber.ToString()),
            _ => throw new InvalidWacmVersionException(WacmContext.Options.WacmVersion)
        };

        public string GetDeleteAccountUrl(int accountNumber) => WacmContext.Options.WacmVersion switch
        {
            WacmVersions.VERSION_1 => Endpoints.V1.Accounts.Delete.Replace(UrlVariables.AccountNumber, accountNumber.ToString()),
            _ => throw new InvalidWacmVersionException(WacmContext.Options.WacmVersion)
        };
    }
}
