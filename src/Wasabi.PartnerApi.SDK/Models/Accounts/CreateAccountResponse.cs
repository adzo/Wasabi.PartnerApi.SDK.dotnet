using System;

namespace Wasabi.PartnerApi.SDK 
{
    public class CreateAccountResponse
    {
        public string AcctName { get; set; }
        public int AcctNum { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public bool IsTrial { get; set; }
        public DateTime TrialExpiry { get; set; }
        public int QuotaGB { get; set; }
        public bool FTPEnabled { get; set; }
        public bool Inactive { get; set; }
        public bool SendPasswordResetToSubAccountEmail { get; set; }
    }
}
