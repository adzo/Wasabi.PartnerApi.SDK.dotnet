# Wasabi PartnerApi SDK

This package can be used for connection to the partner API. It provides service interfaces for account management, utilizations and invoicing:

- IAccountManager
- IUtilizationService
- IInvoicingService

These interfaces will provide the available actions you can do via simple methods that you can use.

This solution contains two projects:
- Wasabi.PartnerApi.SDK
- Wasabi.PartnerApi.SDK.Consumer

## Wasabi.PartnerApi.SDK.Consumer

This is a simple Web Api project to demonstrate the use of the SDK. I went with this type of project since it's simple to create and has swagger enabled to provide us with a GUI ready to use to invoke the several endpoints (PartnerApi.SDK methods calls).


1. Start by adding PartnerApiOptions in your appsettings.json

```
{  
  "PartnerApiOptions": {
    "apiKey": "PUT_YOUR_API_KEY_HERE",
    "isProductionEnvironement": true,
    "PartnerApiVersion": 1
  }
}
```

isProductionEnvironement needs to be set to true for production environement or false for staging (test) environement.
PartnerApiVersion: needs to be set for 1 (version 1) to reach the v1 endpoints of the partner API

2. Add PartnerApi Services in the Startup class in the ConfigureServices method as follows:
```
    public void ConfigureServices(IServiceCollection services)
    {  
        var PartnerApiOptions = new PartnerApiOptions
        {
            ApiKey = Configuration.GetValue<string>("PartnerApiOptions:ApiKey"),
            IsProductionEnvironement = Configuration.GetValue<bool>("PartnerApiOptions:IsProductionEnvironement"),
            PartnerApiVersion = (PartnerApiVersions)Configuration.GetValue<int>("PartnerApiOptions:PartnerApiVersion")
        };

        services.AddWasabiPartnerApi(PartnerApiOptions);
    }
```

3. Inject the needed interface to get access to it's methods:
```
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
```