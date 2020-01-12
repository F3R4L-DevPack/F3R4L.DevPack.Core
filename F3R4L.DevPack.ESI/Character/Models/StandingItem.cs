using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class StandingItem
    {
        [JsonProperty("from_id")]
        public long CharacterId { get; set; }
        [JsonProperty("from_type")]
        public string CharacterType { get; set; }
        [JsonProperty("standing")]
        public float Standing { get; set; }
    }
}
