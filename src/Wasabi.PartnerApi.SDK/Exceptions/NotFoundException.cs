using System;

namespace Wasabi.PartnerApi.SDK.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
