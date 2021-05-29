using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AuthentyME_API.Json.Hwids;
using Newtonsoft.Json;

namespace AuthentyME_API
{
    public static class Hwids
    {
        public static async Task<ResetHwidResponse> ResetHwid(this AuthentyClient authenty, string target_user)
        {
            var response = await authenty.Client.PostAsync(AuthentyClient.Endpoints["hwids"], new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    {"api_key", authenty.ApiKey},
                    {"app_key", authenty.ApplicationKey},
                    {"user_to", target_user},
                    {"type", "reset"}
                }));
            var rawTextResp = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ResetHwidResponse>(rawTextResp);
        }
    }
}