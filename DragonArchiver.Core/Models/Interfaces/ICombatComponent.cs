using System.Collections.Generic;

namespace DragonArchiver.Core.Models;

public interface ICombatComponent
{
	public string? DamageVulnerabilities { get; set; }
	public string? DamageResistances { get; set; }
	public string? DamageImmunities { get; set; }
	public string? ConditionImmunities { get; set; }
	public CreatureSpeedJson? SpeedJson { get; set; }
	public List<Action>? Actions { get; set; }
	public List<Reaction>? Reactions { get; set; }
	public List<string>? Spells { get; set; }
}