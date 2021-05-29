using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AuthentyME_API.Json.Licenses;
using Newtonsoft.Json;

namespace AuthentyME_API
{
    public static class Licenses
    {
        public static async Task<GenerateLicenseResponse> GenerateLicense(this AuthentyClient authenty, int amount, int expiryDays, string format = "XXXX-XXXX-XXXX-XXXX", int level = 1, bool hwidlock = true)
        {
            var response = await authenty.Client.PostAsync(AuthentyClient.Endpoints["licenses"], new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"api_key", authenty.ApiKey},
                {"app_key", authenty.ApplicationKey},
                {"amount", amount.ToString()},
                {"hwidlocked", hwidlock.ToString()},
                {"days", expiryDays.ToString()},
                {"format", format},
                {"type", "generate"}
            }));
            var rawTextResp = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<GenerateLicenseResponse>(rawTextResp);
        }

        public static async Task<GetLicenseInformationResponse> GetLicenseInformation(this AuthentyClient authenty, string licenseKey)
        {
            var response = await authenty.Client.PostAsync(AuthentyClient.Endpoints["licenses"], new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"api_key", authenty.ApiKey},
                {"app_key", authenty.ApplicationKey},
                {"license", licenseKey},
                {"type", "information"}
            }));
            var rawTextResp = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<GetLicenseInformationResponse>(rawTextResp);
        }
        
        public static async Task<DeleteLicenseResponse> DeleteLicense(this AuthentyClient authenty, string licenseKey)
        {
            var response = await authenty.Client.PostAsync(AuthentyClient.Endpoints["licenses"], new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"api_key", authenty.ApiKey},
                {"app_key", authenty.ApplicationKey},
                {"license", licenseKey},
                {"type", "delete"}
            }));
            var rawTextResp = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DeleteLicenseResponse>(rawTextResp);
        }
    }
}