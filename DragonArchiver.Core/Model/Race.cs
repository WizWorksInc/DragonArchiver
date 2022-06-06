namespace DragonArchiver.Core.Model
{
    public class Asi
    {
        public List<string> attributes { get; set; }
        public int value { get; set; }
    }

    public class Race
    {
        public string name { get; set; }
        public string desc { get; set; }

        [JsonProperty("asi-desc")]
        public string AsiDesc { get; set; }
        public List<Asi> asi { get; set; }
        public string age { get; set; }
        public string alignment { get; set; }
        public string size { get; set; }
        public Speed speed { get; set; }

        [JsonProperty("speed-desc")]
        public string SpeedDesc { get; set; }
        public string languages { get; set; }
        public string vision { get; set; }
        public string traits { get; set; }
        public List<Subtype> subtypes { get; set; }
    }

    public class Speed
    {
        public int walk { get; set; }
    }

    public class Subtype
    {
        public string name { get; set; }
        public string desc { get; set; }

        [JsonProperty("asi-desc")]
        public string AsiDesc { get; set; }
        public List<Asi> asi { get; set; }
        public string traits { get; set; }
    }
}
