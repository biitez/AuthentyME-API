using System.Collections.Generic;

namespace AuthentyME_API.Json.Licenses
{
    public class GenerateLicenseResponse
    {
        public bool success { get; set; }
        public List<string> licenses { get; set; }
    }
}