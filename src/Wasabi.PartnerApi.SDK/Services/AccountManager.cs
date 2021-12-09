using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Wasabi.PartnerApi.SDK.Abstractions.Internals;
using Wasabi.PartnerApi.SDK.Configuration;
using Wasabi.PartnerApi.SDK.Helpers;
using Wasabi.PartnerApi.SDK.Http;

namespace Wasabi.PartnerApi.SDK.Services
{
    internal sealed class AccountManager : IAccountManager
    {
        private readonly IHttpClientBuilder _httpClientBuilder;
        private readonly IEndpointsFactory _endpointsFactory;

        public AccountManager(IHttpClientBuilder httpClientBuilder, IEndpointsFactory endpointsFactory)
        {
            _httpClientBuilder = httpClientBuilder;
            _endpointsFactory = endpointsFactory;
        }

        public async Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest requestObject)
        {
            //Guards.CheckForNull("CreateAccount request cannot be null");
            var jsonObject = JsonHelper.Serialize(requestObject);

            var stringContent = new StringContent(jsonObject, Encoding.UTF8, PartnerApiDefaults.JsonContentType);

            using var client = _httpClientBuilder.BuildHttpClient();

            var response = await client.PutAsync(_endpointsFactory.GetCreateAccountUrl(), stringContent);

            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();

            var createdAccount = JsonHelper.Deserialize<CreateAccountResponse>(responseContent);

            return createdAccount;
        }

        public async Task<Response> DeleteAccountAsync(int accountNumber)
        {
            using var client = _httpClientBuilder.BuildHttpClient();

            var response = await client.DeleteAsync(_endpointsFactory.GetDeleteAccountUrl(accountNumber));

            response.EnsureSuccessStatusCode();

            return new Response { HasErrors = false };

            //if (response.IsSuccessStatusCode)
            //{
            //    return new Response { HasErrors = false };
            //}
            //else
            //{
            //    var wcmResponse = JsonSerializer.Deserialize<PartnerApiResponseMessage>(await response.Content.ReadAsStringAsync());
            //    throw new NotFoundException(wcmResponse.Msg);
            //}
        }

        public async Task<ListAccountsResponse> ListAccountsAsync()
        {
            using var client = _httpClientBuilder.BuildHttpClient();

            var response = await client.GetAsync(_endpointsFactory.GetListAccountsUrl());

            response.EnsureSuccessStatusCode();

            return JsonHelper.Deserialize<ListAccountsResponse>(await response.Content.ReadAsStringAsync()); 
        }

        public async Task<UpdateAccountResponse> UpdateAccountAsync(int accountNumber, UpdateAccountRequest requestObject)
        {
            //Guards.CheckForNull("CreateAccount request cannot be null");
            var jsonObject = JsonHelper.Serialize(requestObject);

            var stringContent = new StringContent(jsonObject, Encoding.UTF8, PartnerApiDefaults.JsonContentType);

            using var client = _httpClientBuilder.BuildHttpClient();

            var response = await client.PostAsync(_endpointsFactory.GetUpdateAccountUrl(accountNumber), stringContent);

            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();

            var updatedAccount = JsonHelper.Deserialize<UpdateAccountResponse>(responseContent);

            return updatedAccount;
        }
    }
}
