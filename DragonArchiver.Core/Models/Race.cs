using System.Collections.Generic;

namespace DragonArchiver.Core.Models
{
    public class Asi
    {
        public List<string>? Attributes { get; set; }
        public int Value { get; set; }
    }

    public class Race
    {
        public string? Name { get; set; }
        public string? Desc { get; set; }

        
        public string? AsiDesc { get; set; }
        public List<Asi>? Asi { get; set; }
        public string? Age { get; set; }
        public string? Alignment { get; set; }
        public string? Size { get; set; }
        public Speed? Speed { get; set; }

        
        public string? SpeedDesc { get; set; }
        public string? Languages { get; set; }
        public string? Vision { get; set; }
        public string? Traits { get; set; }
        public List<Subtype>? Subtypes { get; set; }
    }

    public class Speed
    {
        public int Walk { get; set; }
    }

    public class Subtype
    {
        public string? Name { get; set; }
        public string? Desc { get; set; }

        
        public string? AsiDesc { get; set; }
        public List<Asi>? Asi { get; set; }
        public string? Traits { get; set; }
    }
}
