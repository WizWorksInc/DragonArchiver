using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArchiver.Core.Model
{
    internal class Item
    {
        public string Name { get; set; }
        public char Type { get; set; }
        public string Rarity { get; set; }
        public string Value { get; set; }
        public string Weight { get; set; }
        public string Source { get; set; }
        public uint Page { get; set; }
        public List<object> Entries { get; set; }
        
        public string WeaponCategory { get; set; }
        public bool RequiresAttunement { get; set; }


    }
}
