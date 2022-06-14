using Newtonsoft.Json;

namespace DragonArchiver.Core.Models;

public class SpecialAbility
{
	[JsonProperty("name")] public string? Name { get; set; }
	[JsonProperty("desc")] public string? Desc { get; set; }
	[JsonProperty("attack_bonus")] public int AttackBonus { get; set; }
	[JsonProperty("damage_dice")] public string? DamageDice { get; set; }
}