using Newtonsoft.Json;

namespace AuthentyME_API.Json.Licenses
{
    public class UserInfo
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string HWID { get; set; }
        public string LastLogin { get; set; }
        public string LastIPAddress { get; set; }
        public bool Suspended { get; set; }
        public string SuspendedReason { get; set; }
    }
    public class GetLicenseInformationResponse
    {
        public bool success { get; set; }
        public string License { get; set; }
        [JsonProperty("hwid-Locked")]
        public bool HwidLocked { get; set; }
        public int Level { get; set; }
        public bool isLifetime { get; set; }
        public bool Used { get; set; }
        public UserInfo userInfo { get; set; }
    }
}