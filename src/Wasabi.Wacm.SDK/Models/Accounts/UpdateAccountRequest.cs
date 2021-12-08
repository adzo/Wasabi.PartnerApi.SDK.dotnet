namespace Wasabi.Wacm.SDK
{
    public class UpdateAccountRequest
    {
        public string AcctName { get; set; }
        public int NumTrialDays { get; set; }
        public string Password { get; set; }
        public int QuotaGB { get; set; }
        public bool ResetAccessKeys { get; set; }
        public bool EnableFTP { get; set; }
        public bool ConvertToPaid { get; set; }
        public bool PasswordResetRequired { get; set; }
        public bool Inactive { get; set; }
        public bool SendPasswordResetToSubAccountEmail { get; set; }
    }
}
