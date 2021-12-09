using System.Text.Json;

namespace Wasabi.PartnerApi.SDK.Helpers
{
    internal static class JsonHelper
    {
        internal static string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize(obj);
        }

        internal static TInput Deserialize<TInput>(string jsonString)
        {
            return JsonSerializer.Deserialize<TInput>(jsonString);
        }
    }
}
