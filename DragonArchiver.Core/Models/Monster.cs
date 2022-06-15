using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DragonArchiver.Core.Models;

/// <summary>
/// A representation of a monster. This class is the root class for handling our JSON data.
/// </summary>
public class Monster : Creature, ICombatComponent
{
	public override string? Name { get; set; }
	public override string? Size { get; set; }
	public override string? Type { get; set; }
	public override string? Subtype { get; set; }
	public override string? Alignment { get; set; }
	public override int ArmorClass { get; set; }
	public override int HitPoints { get; set; }
	public override string? HitDice { get; set; }
	public override string? Speed { get; set; }
	public override int Strength { get; set; }
	public override int Dexterity { get; set; }
	public override int Constitution { get; set; }
	public override int Intelligence { get; set; }
	public override int Wisdom { get; set; }
	public override int Charisma { get; set; }
	public override int? Acrobatics { get; set; }
	public override int? Arcana { get; set; }
	public override int? Athletics { get; set; }
	public override int? Deception { get; set; }
	public override int History { get; set; }
	public override int? Insight { get; set; }
	public override int? Intimidation { get; set; }
	public override int? Investigation { get; set; }
	public override int? Medicine { get; set; }
	public override int? Nature { get; set; }
	public override int Perception { get; set; }
	public override int? Performance { get; set; }
	public override int? Persuasion { get; set; }
	public override int? Religion { get; set; }
	public override int? Stealth { get; set; }
	public override int? Survival { get; set; }
	public override int? StrengthSave { get; set; }
	public override int? DexteritySave { get; set; }
	public override int ConstitutionSave { get; set; }
	public override int IntelligenceSave { get; set; }
	public override int WisdomSave { get; set; }
	public override int? CharismaSave { get; set; }
	public override string? Senses { get; set; }
	public override string? Languages { get; set; }
	
	
	[JsonPropertyName("damage_vulnerabilities")] public string? DamageVulnerabilities { get; set; }
	[JsonPropertyName("damage_resistances")] public string? DamageResistances { get; set; }
	[JsonPropertyName("damage_immunities")] public string? DamageImmunities { get; set; }
	[JsonPropertyName("conditional_immunities")] public string? ConditionImmunities { get; set; }
	[JsonPropertyName("speed_json")] public CreatureSpeedJson? SpeedJson { get; set; }
	[JsonPropertyName("actions")] public List<Action>? Actions { get; set; }
	[JsonPropertyName("reactions")] public List<Reaction>? Reactions { get; set; }
	[JsonPropertyName("spells")] public List<string>? Spells { get; set; }
	[JsonPropertyName("armor_desc")] public string? ArmorDescription { get; set; }
	[JsonPropertyName("challenge_rating")] public string? ChallengeRating { get; set; }
	[JsonPropertyName("special_abilities")] public List<SpecialAbility>? SpecialAbilities { get; set; }
	[JsonPropertyName("legendary_desc")] public string? LegendaryDescription { get; set; }
	[JsonPropertyName("legendary_actions")] public List<LegendaryAction>? LegendaryActions { get; set; }
	[JsonPropertyName("group")] public string? Group { get; set; }

}