using Newtonsoft.Json;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class PortraitInformation
    {
        [JsonIgnore]
        public long CharacterId { get; set; }

        [JsonProperty("px128x128")]
        public string Pixel128 { get; set; }
        [JsonProperty("px256x256")]
        public string Pixel256 { get; set; }
        [JsonProperty("px512x512")]
        public string Pixel512 { get; set; }
        [JsonProperty("px64x64")]
        public string Pixel64 { get; set; }
    }
}
