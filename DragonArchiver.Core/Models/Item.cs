using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace DragonArchiver.Core.Models;

/// <summary>
/// An object representation of an Item in Dungeons and Dragons.
/// </summary>
public class Item
{

    [JsonPropertyName("name)]
    public string? Name { get; set; }
    [JsonPropertyName("desc")]
    public string? Desc { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    [JsonPropertyName("rarity")]
    public string? Rarity { get; set; }

}
