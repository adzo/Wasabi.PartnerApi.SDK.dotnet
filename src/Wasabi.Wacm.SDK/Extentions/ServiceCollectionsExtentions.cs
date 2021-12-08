
using System;
using Wasabi.Wacm.SDK;
using Wasabi.Wacm.SDK.Configuration;
using Wasabi.Wacm.SDK.Exceptions;
using Wasabi.Wacm.SDK.Http;
using Wasabi.Wacm.SDK.Services; 

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionsExtentions
    {
        public static void AddWacm(this IServiceCollection services, WacmOptions options)
        {
            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (string.IsNullOrEmpty(options.ApiKey))
            {
                throw new ApikeyNotSpecifiedException();
            }

            WacmContext.Options = options; 

            services.AddScoped<Wasabi.Wacm.SDK.Http.IHttpClientBuilder, HttpClientBuilder>();
            services.AddScoped<IAccountManager, AccountManager>();
        }
    }
}
