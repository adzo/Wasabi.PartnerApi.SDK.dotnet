using System.Net.Http;

namespace Wasabi.PartnerApi.SDK.Http
{
    internal interface IHttpClientBuilder
    {
        HttpClient BuildHttpClient();
    }
}