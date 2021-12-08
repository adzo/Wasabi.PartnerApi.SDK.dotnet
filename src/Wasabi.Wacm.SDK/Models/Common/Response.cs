using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasabi.Wacm.SDK
{
    public class Response
    {
        public bool HasErrors { get; set; }
        public string ErrorMessage { get; set; }
    }

    internal class WacmResponseMessage
    {
        public string Msg { get; set; }
    }
}
