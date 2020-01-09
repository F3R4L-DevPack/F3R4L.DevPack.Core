using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class NotificationCollection
    {
        public long CharacterId { get; set; }
        public IEnumerable<NotificationItem> Notifications { get; set; }
    }
}
