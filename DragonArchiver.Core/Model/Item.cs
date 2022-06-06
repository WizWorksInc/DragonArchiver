using System.Diagnostics.CodeAnalysis;

namespace DragonArchiver.Core.Model;

/// <summary>
/// An object representation of an Item in Dungeons and Dragons.
/// </summary>
public class Item
{

    public string? name { get; set; }
    public string? desc { get; set; }
    public string? type { get; set; }
    public string? rarity { get; set; }

}
