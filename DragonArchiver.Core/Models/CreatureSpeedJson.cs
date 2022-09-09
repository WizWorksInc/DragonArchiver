using System.Text.Json.Serialization;

namespace DragonArchiver.Core.Models;

public class CreatureSpeedJson
{
	[JsonPropertyName("walk")] public int Walk { get; set; }
	[JsonPropertyName("swim")] public int Swim { get; set; }
	[JsonPropertyName("fly")] public int? Fly { get; set; }
	[JsonPropertyName("burrow")] public int? Burrow { get; set; }
	[JsonPropertyName("climb")] public int? Climb { get; set; }
	[JsonPropertyName("hover")] public bool? Hover { get; set; }
	[JsonPropertyName("notes")] public string? Notes { get; set; }
}