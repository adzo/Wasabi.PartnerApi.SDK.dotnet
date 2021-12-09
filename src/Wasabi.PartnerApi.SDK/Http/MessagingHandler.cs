using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Wasabi.PartnerApi.SDK.Configuration;

namespace Wasabi.PartnerApi.SDK.Http
{
    internal class MessagingHandler: DelegatingHandler
    {
        public MessagingHandler()
        {
            InnerHandler = new HttpClientHandler();
        }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Authorization", PartnerApiContext.Options.ApiKey);
            request.Headers.Add("User-Agent", "Wasabi.PartnerApi.SDK");
            request.Headers.Add("Accept", PartnerApiDefaults.JsonContentType);

            return base.SendAsync(request, cancellationToken);
        }
    }
}
