using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasabi.PartnerApi.SDK
{
    public class Response
    {
        public bool HasErrors { get; set; }
        public string ErrorMessage { get; set; }
    }

    internal class PartnerApiResponseMessage
    {
        public string Msg { get; set; }
    }
}
