using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasabi.PartnerApi.SDK.Configuration
{
    internal static class PartnerApiContext
    {
        public static PartnerApiOptions Options;

        public static string BaseUrl => Options.IsProductionEnvironement ? PartnerApiDefaults.ProductionEnvironement : PartnerApiDefaults.StagingEnvironement;
    }
}
