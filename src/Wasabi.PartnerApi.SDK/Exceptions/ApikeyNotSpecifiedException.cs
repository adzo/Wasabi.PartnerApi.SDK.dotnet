using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasabi.PartnerApi.SDK.Exceptions
{
    public class ApikeyNotSpecifiedException: Exception
    {
        public ApikeyNotSpecifiedException(): base("No Api key is specified")
        { 
        }
    }
}
