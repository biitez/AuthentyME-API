using System.Collections.Generic;
using System.Net.Http;

namespace AuthentyME_API
{
    public class AuthentyClient
    {
        public static readonly Dictionary<string, string> Endpoints = new()
        {
            {"licenses", "https://biitez.dev/api/authenty/licenses/"},
            {"hwids", "https://biitez.dev/api/authenty/hwid/"},
            {"users", "https://biitez.dev/api/authenty/users/"}
        };
        
        public readonly HttpClient Client = new();
        public string ApiKey { get; }
        public string ApplicationKey { get; }
        public AuthentyClient(string userApiKey, string applicationKey)
        {
            ApiKey = userApiKey;
            ApplicationKey = applicationKey;
        }
    }
}