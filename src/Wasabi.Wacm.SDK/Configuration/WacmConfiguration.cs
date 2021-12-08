using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasabi.Wacm.SDK.Configuration
{
    internal static class WacmContext
    {
        public static WacmOptions Options;

        public static string BaseUrl => Options.IsProductionEnvironement ? WacmDefaults.ProductionEnvironement : WacmDefaults.StagingEnvironement;
    }
}
