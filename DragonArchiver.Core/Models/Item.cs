using System.Diagnostics.CodeAnalysis;

namespace DragonArchiver.Core.Models;

/// <summary>
/// An object representation of an Item in Dungeons and Dragons.
/// </summary>
public class Item
{

    public string? Name { get; set; }
    public string? Desc { get; set; }
    public string? Type { get; set; }
    public string? Rarity { get; set; }

}
