using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class StandingCollection
    {
        public long CharacterId { get; set; }
        public IEnumerable<StandingItem> Standings { get; set; }
    }
}
