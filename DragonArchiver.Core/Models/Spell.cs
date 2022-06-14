using Newtonsoft.Json;

namespace DragonArchiver.Core.Models
{
    public class Spell
    {
        [JsonProperty("name")] public string? Name { get; set; }
        [JsonProperty("desc")] public string? Desc { get; set; }
        [JsonProperty("higher_level")] public string? HigherLevel { get; set; }
        [JsonProperty("page")] public string? Page { get; set; }
        [JsonProperty("range")] public string? Range { get; set; }
        [JsonProperty("components")] public string? Components { get; set; }
        [JsonProperty("material")] public string? Material { get; set; }
        [JsonProperty("ritual")] public string? Ritual { get; set; }
        [JsonProperty("duration")] public string? Duration { get; set; }
        [JsonProperty("concentration")] public string? Concentration { get; set; }
        [JsonProperty("casting_time")] public string? CastingTime { get; set; }
        [JsonProperty("level")] public string? Level { get; set; }
        [JsonProperty("level_int")] public int LevelInt { get; set; }
        [JsonProperty("school")] public string? School { get; set; }
        [JsonProperty("class")] public string? Class { get; set; }
        [JsonProperty("archetype")] public string? Archetype { get; set; }
        [JsonProperty("circles")] public string? Circles { get; set; }
        [JsonProperty("domains")] public string? Domains { get; set; }
        [JsonProperty("oaths")] public string? Oaths { get; set; }
        [JsonProperty("patrons")] public string? Patrons { get; set; }
    }
}
