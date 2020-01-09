using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class ContactNotificationCollection
    {
        public long CharacterId { get; set; }
        public IEnumerable<ContactNotificationItem> Notifications { get; set; }
    }
}
