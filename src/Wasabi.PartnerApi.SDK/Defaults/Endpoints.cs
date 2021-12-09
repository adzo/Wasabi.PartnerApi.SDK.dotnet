namespace Wasabi.PartnerApi.SDK.Configuration
{
    internal class Endpoints
    {
        internal class V1
        { 
            internal class Accounts
            { 

                public static string List = "/v1/accounts";
                public static string Create = "/v1/accounts";
                public static string Update = $"/v1/accounts/{UrlVariables.AccountNumber}";
                public static string Delete = $"/v1/accounts/{UrlVariables.AccountNumber}";
            }
        }
    }
}
