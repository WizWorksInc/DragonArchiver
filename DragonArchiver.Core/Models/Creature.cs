using System.Text.Json.Serialization;

namespace DragonArchiver.Core.Models
{
	/// <summary>
	/// An abstract implementation of a creature.
	/// The point of this class is to implement the core items required of both a monster and a player.
	/// </summary>
	public abstract class Creature
    {
	    [JsonPropertyName("name")] public abstract string? Name { get; set; }
        [JsonPropertyName("size")] public abstract string? Size { get; set; }
        [JsonPropertyName("type")] public abstract string? Type { get; set; }
        [JsonPropertyName("subtype")] public abstract string? Subtype { get; set; }
        [JsonPropertyName("alignment")] public abstract string? Alignment { get; set; }
        [JsonPropertyName("armor_class")] public abstract int ArmorClass { get; set; }
        [JsonPropertyName("hit_points")] public abstract int HitPoints { get; set; }
        [JsonPropertyName("hit_dice")] public abstract string? HitDice { get; set; }
        [JsonPropertyName("speed")] public abstract string? Speed { get; set; }
        [JsonPropertyName("strength")] public abstract int Strength { get; set; }
        [JsonPropertyName("dexterity")] public abstract int Dexterity { get; set; }
        [JsonPropertyName("constitution")] public abstract int Constitution { get; set; }
        [JsonPropertyName("intelligence")] public abstract int Intelligence { get; set; }
        [JsonPropertyName("wisdom")] public abstract int Wisdom { get; set; }
        [JsonPropertyName("charisma")] public abstract int Charisma { get; set; }
        [JsonPropertyName("acrobatics")] public abstract int? Acrobatics { get; set; }
		// animal handling
		[JsonPropertyName("arcana")] public abstract int? Arcana { get; set; }
		[JsonPropertyName("athletics")] public abstract int? Athletics { get; set; }
		[JsonPropertyName("deception")] public abstract int? Deception { get; set; }
		[JsonPropertyName("history")] public abstract int History { get; set; }
		[JsonPropertyName("insight")] public abstract int? Insight { get; set; }
		[JsonPropertyName("intimidation")] public abstract int? Intimidation { get; set; }
		[JsonPropertyName("investigation")] public abstract int? Investigation { get; set; }
		[JsonPropertyName("medicine")] public abstract int? Medicine { get; set; }
		[JsonPropertyName("nature")] public abstract int? Nature { get; set; }
		[JsonPropertyName("perception")] public abstract int Perception { get; set; }
		[JsonPropertyName("performance")] public abstract int? Performance { get; set; }
		[JsonPropertyName("persuasion")] public abstract int? Persuasion { get; set; }
		[JsonPropertyName("religion")] public abstract int? Religion { get; set; }
		// sleight of hand
		[JsonPropertyName("stealth")] public abstract int? Stealth { get; set; }
		[JsonPropertyName("survival")] public abstract int? Survival { get; set; }

		[JsonPropertyName("strength_save")] public abstract int? StrengthSave { get; set; }
		[JsonPropertyName("dexterity_save")] public abstract int? DexteritySave { get; set; } 
		[JsonPropertyName("constitution_save")] public abstract int ConstitutionSave { get; set; }		
		[JsonPropertyName("intelligence_save")] public abstract int IntelligenceSave { get; set; }		
		[JsonPropertyName("wisdom_save")] public abstract int WisdomSave { get; set; }		
		[JsonPropertyName("charisma_save")] public abstract int? CharismaSave { get; set; }		
		[JsonPropertyName("senses")] public abstract string? Senses { get; set; }		
		[JsonPropertyName("languages")] public abstract string? Languages { get; set; }

    }
}
