using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class ContactNotificationItem
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        [JsonProperty(PropertyName = "notification_id")]
        public long NotificationId { get; set; }
        [JsonProperty(PropertyName = "send_date")]
        public DateTime SentDate { get; set; }
        [JsonProperty(PropertyName = "sender_character_id")]
        public long SenderId { get; set; }
        [JsonProperty(PropertyName = "standing_level")]
        public decimal Standing { get; set; }
    }
}
