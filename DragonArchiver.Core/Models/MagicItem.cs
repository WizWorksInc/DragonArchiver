using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace DragonArchiver.Core.Models;

/// <summary>
/// An object representation of an Item in Dungeons and Dragons.
/// </summary>
public class MagicItem
{
    public string name { get; set; }
    public string desc { get; set; }
    public string type { get; set; }
    public string rarity { get; set; }

    [JsonProperty("requires-attunement")]
    public string? RequiresAttunement { get; set; }
    

}
