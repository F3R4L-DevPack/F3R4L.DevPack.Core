using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class Medal
    {
        [JsonProperty("corporation_id")]
        public long CorporationId { get; set; }
        [JsonProperty("date")]
        public DateTime Issued { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("issuer_id")]
        public long IssuerId { get; set; }
        [JsonProperty("medal_id")]
        public long MedalId { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("graphics")]
        public IEnumerable<GraphicDescriptor> Graphics { get; set; }

        public class GraphicDescriptor
        {
            [JsonProperty("color")]
            public int Colour { get; set; }
            [JsonProperty("graphic")]
            public string Graphic { get; set; }
            [JsonProperty("layer")]
            public int Layer { get; set; }
            [JsonProperty("part")]
            public int Part { get; set; }
        }
    }
}