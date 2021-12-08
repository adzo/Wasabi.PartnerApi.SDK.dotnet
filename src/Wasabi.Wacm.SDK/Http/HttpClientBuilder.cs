using System;
using System.Net.Http;
using Wasabi.Wacm.SDK.Configuration;

namespace Wasabi.Wacm.SDK.Http
{
    internal class HttpClientBuilder : IHttpClientBuilder
    {
        public HttpClient BuildHttpClient()
        {
            return new HttpClient(new MessagingHandler(), true)
            {
                BaseAddress = new Uri(WacmContext.BaseUrl)
            };
        }
    }
}
