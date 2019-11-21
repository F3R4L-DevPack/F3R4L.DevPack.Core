using Newtonsoft.Json;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class AffiliationItem
    {
        [JsonProperty(PropertyName = "alliance_id")]
        public int AllianceId { get; set; }
        [JsonProperty(PropertyName = "character_id")]
        public int CharacterId { get; set; }
        [JsonProperty(PropertyName = "corporation_id")]
        public int CorporationId { get; set; }
    }
}
