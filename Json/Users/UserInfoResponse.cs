namespace AuthentyME_API.Json.Users
{
    public class UserInfoResponse
    {
        public bool success { get; set; }
        public bool isbanned { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string hwid { get; set; }
        public string lastipaddress { get; set; }
        public string lastlogin { get; set; }
    }
}