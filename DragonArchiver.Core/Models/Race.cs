using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DragonArchiver.Core.Models
{
    public class Asi
    {
        [JsonPropertyName("attributes")] public List<string>? Attributes { get; set; }
        [JsonPropertyName("value")] public int Value { get; set; }
    }

    public class Race
    {
        [JsonPropertyName("name")] public string? Name { get; set; }
        [JsonPropertyName("desc")] public string? Desc { get; set; }
        [JsonPropertyName("asi_desc")] public string? AsiDesc { get; set; }
        [JsonPropertyName("asi")] public List<Asi>? Asi { get; set; }
        [JsonPropertyName("age")] public string? Age { get; set; }
        [JsonPropertyName("alignment")] public string? Alignment { get; set; }
        [JsonPropertyName("size")] public string? Size { get; set; }
        [JsonPropertyName("speed")] public Speed? Speed { get; set; }
        [JsonPropertyName("speed_desc")] public string? SpeedDesc { get; set; }
        [JsonPropertyName("languages")] public string? Languages { get; set; }
        [JsonPropertyName("vision")] public string? Vision { get; set; }
        [JsonPropertyName("traits")] public string? Traits { get; set; }
        [JsonPropertyName("subtypes")] public List<Subtype>? Subtypes { get; set; }
    }

    public class Speed
    {
        [JsonPropertyName("walk")] public int Walk { get; set; }
    }

    public class Subtype
    {
        [JsonPropertyName("name")] public string? Name { get; set; }
        [JsonPropertyName("desc")] public string? Desc { get; set; }
        [JsonPropertyName("asi_desc")] public string? AsiDesc { get; set; }
        [JsonPropertyName("asi")] public List<Asi>? Asi { get; set; }
        [JsonPropertyName("traits")] public string? Traits { get; set; }
    }
}
