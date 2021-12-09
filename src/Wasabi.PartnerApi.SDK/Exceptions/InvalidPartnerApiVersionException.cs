using System;

namespace Wasabi.PartnerApi.SDK.Exceptions
{
    public class InvalidPartnerApiVersionException : Exception
    {
        public InvalidPartnerApiVersionException(PartnerApiVersions PartnerApiVersion) : base($"Invalid specified PartnerApiVersion | Specified value: {PartnerApiVersion}")
        {

        }
    }
}
