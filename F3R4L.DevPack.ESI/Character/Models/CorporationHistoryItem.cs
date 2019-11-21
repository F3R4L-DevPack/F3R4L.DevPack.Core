using Newtonsoft.Json;
using System;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class CorporationHistoryItem
    {
        [JsonProperty(PropertyName = "corporation_id")]
        public long CorporationId { get; set; }

        [JsonProperty(PropertyName = "record_id")]
        public long RecordId { get; set; }

        [JsonProperty(PropertyName = "start_date")]
        public DateTime StartDate { get; set; }
    }
}
