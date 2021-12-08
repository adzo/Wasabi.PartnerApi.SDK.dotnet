﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Wasabi.Wacm.SDK.Consumer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController: ControllerBase
    {
        private readonly IAccountManager _accountManager;

        public AccountController(IAccountManager accountManager)
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
