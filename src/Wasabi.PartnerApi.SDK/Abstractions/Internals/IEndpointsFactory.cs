namespace Wasabi.PartnerApi.SDK.Abstractions.Internals
{
    internal interface IEndpointsFactory
    {
        string GetCreateAccountUrl();
        string GetDeleteAccountUrl(int accountNumber);
        string GetListAccountsUrl();
        string GetUpdateAccountUrl(int accountNumber);
    }
}