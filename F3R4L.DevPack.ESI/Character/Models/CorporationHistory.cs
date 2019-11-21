using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class CorporationHistory
    {
        public long CharacterId { get; set; }
        public IEnumerable<CorporationHistoryItem> CorporationHistoryItems { get; set; }
    }
}
