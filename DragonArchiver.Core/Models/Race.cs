using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonArchiver.Core.Models
{
    public class Asi
    {
        [JsonProperty("attributes")] public List<string>? Attributes { get; set; }
        [JsonProperty("value")] public int Value { get; set; }
    }

    public class Race
    {
        [JsonProperty("name")] public string? Name { get; set; }
        [JsonProperty("desc")] public string? Desc { get; set; }
        [JsonProperty("asi_desc")] public string? AsiDesc { get; set; }
        [JsonProperty("asi")] public List<Asi>? Asi { get; set; }
        [JsonProperty("age")] public string? Age { get; set; }
        [JsonProperty("alignment")] public string? Alignment { get; set; }
        [JsonProperty("size")] public string? Size { get; set; }
        [JsonProperty("speed")] public Speed? Speed { get; set; }
        [JsonProperty("speed_desc")] public string? SpeedDesc { get; set; }
        [JsonProperty("languages")] public string? Languages { get; set; }
        [JsonProperty("vision")] public string? Vision { get; set; }
        [JsonProperty("traits")] public string? Traits { get; set; }
        [JsonProperty("subtypes")] public List<Subtype>? Subtypes { get; set; }
    }

    public class Speed
    {
        [JsonProperty("walk")] public int Walk { get; set; }
    }

    public class Subtype
    {
        [JsonProperty("name")] public string? Name { get; set; }
        [JsonProperty("desc")] public string? Desc { get; set; }
        [JsonProperty("asi_desc")] public string? AsiDesc { get; set; }
        [JsonProperty("asi")] public List<Asi>? Asi { get; set; }
        [JsonProperty("traits")] public string? Traits { get; set; }
    }
}
