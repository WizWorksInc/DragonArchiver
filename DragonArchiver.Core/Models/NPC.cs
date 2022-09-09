using System.Collections.Generic;

namespace DragonArchiver.Core.Models
{
    internal class Npc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<object>? Relationships { get; set; }
        public Dictionary<string, string>? Personality;
        public string? Backstory { get; set; }
        public List<object>? CommonLocations { get; set; }

        public Npc(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
