using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AuthentyME_API.Json.Users;
using Newtonsoft.Json;

namespace AuthentyME_API
{
    public static class Users
    {

        public static async Task<BanRespose> BanUser(this AuthentyClient authenty, string target_user)
        {
            var response = await authenty.Client.PostAsync(AuthentyClient.Endpoints["users"], new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"api_key", authenty.ApiKey},
                {"app_key", authenty.ApplicationKey},
                {"type", "ban"},
                {"user_to", target_user}
            }));
            var rawTextResp = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BanRespose>(rawTextResp);
        }
        
        public static async Task<UnbanResponse> UnbanUser(this AuthentyClient authenty, string target_user)
        {
            var response = await authenty.Client.PostAsync(AuthentyClient.Endpoints["users"], new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"api_key", authenty.ApiKey},
                {"app_key", authenty.ApplicationKey},
                {"type", "unban"},
                {"user_to", target_user}
            }));
            var rawTextResp = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UnbanResponse>(rawTextResp);
        }
        
        public static async Task<PasswordChangeResponse> ChangeUserPassword(this AuthentyClient authenty, string target_user, string new_password) 
        {
            var response = await authenty.Client.PostAsync(AuthentyClient.Endpoints["users"], new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    {"api_key", authenty.ApiKey},
                    {"app_key", authenty.ApplicationKey},
                    {"type", "change_pass"},
                    {"user_to", target_user},
                    {"new_password", new_password}
                }));
            var rawTextResp = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PasswordChangeResponse>(rawTextResp);
        }
        public static async Task<UserInfoResponse> GetUserInformation(this AuthentyClient authenty, string target_user)
        {
            var response = await authenty.Client.PostAsync(AuthentyClient.Endpoints["users"], new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    {"api_key", authenty.ApiKey},
                    {"app_key", authenty.ApplicationKey},
                    {"user_to", target_user},
                    {"type", "user_information"}
                }));
            var rawTextResp = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UserInfoResponse>(rawTextResp);
        }

        public static async Task<TotalUsersResponse> GetTotalUsers(this AuthentyClient authenty)
        {
            var response = await authenty.Client.PostAsync(AuthentyClient.Endpoints["users"], new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    {"api_key", authenty.ApiKey},
                    {"app_key", authenty.ApplicationKey},
                    {"type", "totalusers"}
                }));
            var rawTextResp = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TotalUsersResponse>(rawTextResp);
        }
    }
}