using System;
using System.Net;

namespace Wasabi.Wacm.SDK.Exceptions
{
    public class WacmException: Exception
    {
        public WacmException(HttpStatusCode statusCode, string message): base($"Status code: {statusCode} | Message: {message}")
        {

        }
    }
}
