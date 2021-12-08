using System.Threading.Tasks;
using Wasabi.Wacm.SDK.Configuration;

namespace Wasabi.Wacm.SDK
{
    public interface IAccountManager
    {
        public Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request);
        public Task<ListAccountsResponse> ListAccountsAsync();
        public Task<Response> DeleteAccountAsync(int accountNumber);
        public Task<UpdateAccountResponse> UpdateAccountAsync(int accountNumber, UpdateAccountRequest request);
    }
}
