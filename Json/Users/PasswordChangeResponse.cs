namespace AuthentyME_API.Json.Users
{
    public class PasswordChangeResponse
    {
        public bool success { get; set; }
        public string error_code { get; set; } = string.Empty;
    }
}