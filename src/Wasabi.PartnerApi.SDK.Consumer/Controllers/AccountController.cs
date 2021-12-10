using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Wasabi.PartnerApi.SDK.Consumer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController: ControllerBase
    {
        private readonly IAccountService _accountManager;

        public AccountController(IAccountService accountManager)
        {
            _accountManager = accountManager;
        }

        [HttpGet]
        public async Task<ListAccountsResponse> Get()
        {
            return await _accountManager.ListAccountsAsync();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int accountNumber)
        {
            var result = await _accountManager.DeleteAccountAsync(accountNumber);

            return Ok(result);
        }
    }
}
