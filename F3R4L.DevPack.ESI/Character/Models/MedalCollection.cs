using System;
using System.Collections.Generic;
using System.Text;

namespace F3R4L.DevPack.ESI.Character.Models
{
    public class MedalCollection
    {
        public long CharacterId { get; set; }
        public IEnumerable<Medal> Medals { get; set; }
    }
}
