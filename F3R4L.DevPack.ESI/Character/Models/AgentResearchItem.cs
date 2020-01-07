using Newtonsoft.Json;
using System;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class AgentResearchItem
    {
        [JsonProperty(PropertyName = "agent_id")]
        public int AgentId { get; set; }
        [JsonProperty(PropertyName = "points_per_day")]
        public long PointsPerDay { get; set; }
        [JsonProperty(PropertyName = "remainder_points")]
        public long RemainingPoints { get; set; }
        [JsonProperty(PropertyName = "skill_type_id")]
        public int SkillTypeId { get; set; }
        [JsonProperty(PropertyName = "started_at")]
        public DateTime StartedAt { get; set; }
    }
}
