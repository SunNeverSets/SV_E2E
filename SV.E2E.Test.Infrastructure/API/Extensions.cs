using Newtonsoft.Json;

namespace SV.E2E.Test.Infrastructure.API
{
    public static class Extensions
    {
        public static T DerializeObject<T>(this string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
