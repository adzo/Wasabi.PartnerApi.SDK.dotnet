using System.Net.Http;

namespace Wasabi.Wacm.SDK.Http
{
    internal interface IHttpClientBuilder
    {
        HttpClient BuildHttpClient();
    }
}