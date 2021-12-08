using System;

namespace Wasabi.Wacm.SDK.Exceptions
{
    public class InvalidWacmVersionException : Exception
    {
        public InvalidWacmVersionException(WacmVersions wacmVersion) : base($"Invalid specified WacmVersion | Specified value: {wacmVersion}")
        {

        }
    }
}
