using System;
using System.Net.Http;
using Wasabi.PartnerApi.SDK.Configuration;

namespace Wasabi.PartnerApi.SDK.Http
{
    internal class HttpClientBuilder : IHttpClientBuilder
    {
        public HttpClient BuildHttpClient()
        {
            return new HttpClient(new MessagingHandler(), true)
            {
                BaseAddress = new Uri(PartnerApiContext.BaseUrl)
            };
        }
    }
}
