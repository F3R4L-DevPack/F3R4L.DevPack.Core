using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class JumpInformation
    {
        [JsonIgnore]
        public long CharacterId { get; set; }
        [JsonProperty("jump_fatigue_expire_date")]
        public DateTime FatigueExpiry { get; set; }
        [JsonProperty("last_jump_date")]
        public DateTime LastJump { get; set; }
        [JsonProperty("last_update_date")]
        public DateTime LastUpdate { get; set; }
    }
}
