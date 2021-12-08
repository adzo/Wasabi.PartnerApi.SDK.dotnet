using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Wasabi.Wacm.SDK.Configuration;

namespace Wasabi.Wacm.SDK.Http
{
    internal class MessagingHandler: DelegatingHandler
    {
        public MessagingHandler()
        {
            InnerHandler = new HttpClientHandler();
        }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Authorization", WacmContext.Options.ApiKey);
            request.Headers.Add("User-Agent", "Wasabi.Wacm.SDK");
            request.Headers.Add("Accept", WacmDefaults.JsonContentType);

            return base.SendAsync(request, cancellationToken);
        }
    }
}
