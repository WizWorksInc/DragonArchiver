using Newtonsoft.Json;

namespace DragonArchiver.Core.Models;

public class CreatureSpeedJson
{
	[JsonProperty("walk")] public int Walk { get; set; }
	[JsonProperty("swim")] public int Swim { get; set; }
	[JsonProperty("fly")] public int? Fly { get; set; }
	[JsonProperty("burrow")] public int? Burrow { get; set; }
	[JsonProperty("climb")] public int? Climb { get; set; }
	[JsonProperty("hover")] public bool? Hover { get; set; }
	[JsonProperty("notes")] public string? Notes { get; set; }
}