using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DragonArchiver.Core.Utils;
//using DragonArchiver.Core.ViewModels;

namespace DragonArchiver.Core.Models;

/// <summary>
/// An object representation of a Magic Item in Dungeons and Dragons.
/// </summary>
public class MagicItem
{
    public MagicItem(
        string name, 
        string description, 
        string type, 
        string rarity, 
        string? requiresAttunement = null)
    {
        Name = name;
        Description = description;
        Type = type;
        Rarity = rarity;
        RequiresAttunement = requiresAttunement;
    }
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("desc")] public string Description { get; set; }
    [JsonPropertyName("type")] public string Type { get; set; }
    [JsonPropertyName("rarity")] public string Rarity { get; set; }
    [JsonPropertyName("requires-attunement")] public string? RequiresAttunement { get; set; }
    
    // public static async Task<IEnumerable<MagicItem>?> LoadContentList()
    // {
    //     return await JsonListReader.LoadJsonAsync<MagicItem>(Resources.magicitems);
    // }

    public static async Task<IEnumerable<MagicItem>?> LoadContentListAsync()
    {
        return await JsonListReader.LoadJsonAsync<MagicItem>(Resources.magicitems);
    }
    
}
