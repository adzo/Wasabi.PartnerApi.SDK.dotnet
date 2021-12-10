
using System;
using Wasabi.PartnerApi.SDK;
using Wasabi.PartnerApi.SDK.Abstractions.Internals;
using Wasabi.PartnerApi.SDK.Configuration;
using Wasabi.PartnerApi.SDK.Exceptions;
using Wasabi.PartnerApi.SDK.Http;
using Wasabi.PartnerApi.SDK.Services; 

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionsExtentions
    {
        public static void AddWasabiPartnerApi(this IServiceCollection services, PartnerApiOptions options)
        {
            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.ApiKey))
            {
                throw new ApikeyNotSpecifiedException();
            }

            PartnerApiContext.Options = options; 

            services.AddScoped<Wasabi.PartnerApi.SDK.Http.IHttpClientBuilder, HttpClientBuilder>();
            services.AddScoped<IEndpointsFactory, EndpointsFactory>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IInvoicingService, InvoicingService>();
            services.AddScoped<IUtilizationService, UtilizationService>();
        }
    }
}
