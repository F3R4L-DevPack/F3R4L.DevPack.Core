using Newtonsoft.Json;
using System;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class NotificationItem
    {
        [JsonProperty(PropertyName = "notification_id")]
        public long NotificationId { get; set; }
        [JsonProperty(PropertyName = "sender_id")]
        public long SenderId { get; set; }
        [JsonProperty(PropertyName = "sender_type")]
        public string SenderType { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "timestamp")]
        public DateTime Timestamp { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "is_read")]
        public bool IsRead { get; set; }
    }
}
