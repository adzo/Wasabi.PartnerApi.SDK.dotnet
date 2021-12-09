using System;
using System.Net;

namespace Wasabi.PartnerApi.SDK.Exceptions
{
    public class PartnerApiException: Exception
    {
        public PartnerApiException(HttpStatusCode statusCode, string message): base($"Status code: {statusCode} | Message: {message}")
        {

        }
    }
}
