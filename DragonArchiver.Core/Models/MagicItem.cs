using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace DragonArchiver.Core.Models;

/// <summary>
/// An object representation of a Magic Item in Dungeons and Dragons.
/// </summary>
public class MagicItem
{
    [JsonProperty("name")] public string Name { get; set; } = null!;
    [JsonProperty("desc")] public string Description { get; set; } = null!;
    [JsonProperty("type")] public string Type { get; set; } = null!;
    [JsonProperty("rarity")] public string Rarity { get; set; } = null!;
    [JsonProperty("requires-attunement")] public string? RequiresAttunement { get; set; }
}
