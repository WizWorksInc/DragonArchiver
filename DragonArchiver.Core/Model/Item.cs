using System.Diagnostics.CodeAnalysis;

namespace DragonArchiver.Core.Model;

/// <summary>
/// An object representation of an Item in Dungeons and Dragons.
/// </summary>
public class Item
{
    public Item(string slug, string name, string type, string desc, string rarity, string requiresAttunement, string documentSlug, string documentTitle)
    {
        Slug = slug;
        Name = name;
        Type = type;
        Desc = desc;
        Rarity = rarity;
        RequiresAttunement = requiresAttunement;
        DocumentSlug = documentSlug;
        DocumentTitle = documentTitle;
    }

    public string Slug { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Desc { get; set; }
    public string Rarity { get; set; }
    public string RequiresAttunement { get; set; }
    public string DocumentSlug { get; set; }
    public string DocumentTitle { get; set; }
}