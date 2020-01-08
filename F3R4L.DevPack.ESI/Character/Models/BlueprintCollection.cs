using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class BlueprintCollection
    {
        public long OwnerId { get; set; }
        public IEnumerable<Blueprint> BlueprintsOwned { get; set; }
    }
}
