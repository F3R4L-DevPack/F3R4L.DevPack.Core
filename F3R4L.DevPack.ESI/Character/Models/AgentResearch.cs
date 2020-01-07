using System.Collections.Generic;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class AgentResearch
    {
        public long CharacterId { get; set; }
        public IEnumerable<AgentResearchItem> ResearchItems { get; set; }
    }
}
