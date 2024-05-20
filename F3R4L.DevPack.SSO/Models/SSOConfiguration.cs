using System.Collections;
using System.Collections.Generic;

namespace F3R4L.DevPack.SSO.Models
{
    public class SSOConfiguration
    {
        public string ClientId { get; set; }
        public string SecretKey { get; set; }
        public string CallbackUrl { get; set; }
        public IEnumerable<string> Scopes { get; set; }
    }
}