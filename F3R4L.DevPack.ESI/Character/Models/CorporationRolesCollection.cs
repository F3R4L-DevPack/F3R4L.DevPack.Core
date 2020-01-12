using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class CorporationRolesCollection
    {
        [JsonIgnore]
        public long CharacterId { get; set; }

        [JsonProperty("roles")]
        public IEnumerable<string> Roles { get; set; }
        [JsonProperty("roles_at_base")]
        public IEnumerable<string> RolesAtBase { get; set; }
        [JsonProperty("roles_at_hq")]
        public IEnumerable<string> RolesAtHQ { get; set; }
        [JsonProperty("roles_at_other")]
        public IEnumerable<string> RolesAtOther { get; set; }
    }
}
