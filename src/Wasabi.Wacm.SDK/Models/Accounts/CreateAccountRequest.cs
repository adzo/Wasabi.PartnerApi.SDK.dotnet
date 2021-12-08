using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasabi.Wacm.SDK
{
    public class CreateAccountRequest
    {
        public string AcctName { get; set; }
        public bool IsTrial { get; set; }
        public bool EnableFTP { get; set; }
        public string Password { get; set; }
        public bool SendPasswordResetToSubAccountEmail { get; set; }
        public bool Inactive { get; set; }
        public int QuotaGB { get; set; }
        public int NumTrialDays { get; set; }
        public bool PasswordResetRequired { get; set; }
    }
}
