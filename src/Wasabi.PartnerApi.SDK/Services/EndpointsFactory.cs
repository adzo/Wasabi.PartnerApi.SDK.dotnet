using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wasabi.PartnerApi.SDK.Abstractions.Internals;
using Wasabi.PartnerApi.SDK.Configuration;
using Wasabi.PartnerApi.SDK.Exceptions;

namespace Wasabi.PartnerApi.SDK.Services
{
    internal class EndpointsFactory : IEndpointsFactory
    {
        public string GetListAccountsUrl() => PartnerApiContext.Options.PartnerApiVersion switch
        {
            PartnerApiVersions.VERSION_1 => Endpoints.V1.Accounts.List,
            _ => throw new InvalidPartnerApiVersionException(PartnerApiContext.Options.PartnerApiVersion)
        };

        public string GetCreateAccountUrl() => PartnerApiContext.Options.PartnerApiVersion switch
        {
            PartnerApiVersions.VERSION_1 => Endpoints.V1.Accounts.Create,
            _ => throw new InvalidPartnerApiVersionException(PartnerApiContext.Options.PartnerApiVersion)
        };

        public string GetUpdateAccountUrl(int accountNumber) => PartnerApiContext.Options.PartnerApiVersion switch
        {
            PartnerApiVersions.VERSION_1 => Endpoints.V1.Accounts.Update.Replace(UrlVariables.AccountNumber, accountNumber.ToString()),
            _ => throw new InvalidPartnerApiVersionException(PartnerApiContext.Options.PartnerApiVersion)
        };

        public string GetDeleteAccountUrl(int accountNumber) => PartnerApiContext.Options.PartnerApiVersion switch
        {
            PartnerApiVersions.VERSION_1 => Endpoints.V1.Accounts.Delete.Replace(UrlVariables.AccountNumber, accountNumber.ToString()),
            _ => throw new InvalidPartnerApiVersionException(PartnerApiContext.Options.PartnerApiVersion)
        };
    }
}
