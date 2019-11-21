using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class Character
    {
        [JsonIgnore]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "alliance_id")]
        public int AllianceId { get; set; }

        [JsonProperty(PropertyName = "ancestry_id")]
        public int AncestryId { get; set; }

        [JsonProperty(PropertyName = "birthday")]
        public DateTime Birthday { get; set; }

        [JsonProperty(PropertyName = "bloodline_id")]
        public int BloodlineId { get; set; }

        [JsonProperty(PropertyName = "corporation_id")]
        public int CorporationId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "race_id")]
        public int RaceId { get; set; }

        [JsonProperty(PropertyName = "security_status")]
        public decimal SecurityStatus { get; set; }
    }

}
