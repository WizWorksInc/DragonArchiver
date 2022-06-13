using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DragonArchiver.Core.Models;

/// <summary>
/// An object representation of an Item in Dungeons and Dragons.
/// </summary>
public class Item
{
    public string Name { get; set; } = null!;
    public string Desc { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Rarity { get; set; } = null!;

    public string? RequiresAttunement { get; set; }
    

}
