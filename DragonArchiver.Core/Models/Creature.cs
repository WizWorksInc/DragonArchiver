using Newtonsoft.Json;

namespace DragonArchiver.Core.Models
{
	/// <summary>
	/// An abstract implementation of a creature.
	/// The point of this class is to implement the core items required of both a monster and a player.
	/// </summary>
	public abstract class Creature
    {
	    [JsonProperty("name")] public abstract string? Name { get; set; }
        [JsonProperty("size")] public abstract string? Size { get; set; }
        [JsonProperty("type")] public abstract string? Type { get; set; }
        [JsonProperty("subtype")] public abstract string? Subtype { get; set; }
        [JsonProperty("alignment")] public abstract string? Alignment { get; set; }
        [JsonProperty("armor_class")] public abstract int ArmorClass { get; set; }
        [JsonProperty("hit_points")] public abstract int HitPoints { get; set; }
        [JsonProperty("hit_dice")] public abstract string? HitDice { get; set; }
        [JsonProperty("speed")] public abstract string? Speed { get; set; }
        [JsonProperty("strength")] public abstract int Strength { get; set; }
        [JsonProperty("dexterity")] public abstract int Dexterity { get; set; }
        [JsonProperty("constitution")] public abstract int Constitution { get; set; }
        [JsonProperty("intelligence")] public abstract int Intelligence { get; set; }
        [JsonProperty("wisdom")] public abstract int Wisdom { get; set; }
        [JsonProperty("charisma")] public abstract int Charisma { get; set; }
        [JsonProperty("acrobatics")] public abstract int? Acrobatics { get; set; }
		// animal handling
		[JsonProperty("arcana")] public abstract int? Arcana { get; set; }
		[JsonProperty("athletics")] public abstract int? Athletics { get; set; }
		[JsonProperty("deception")] public abstract int? Deception { get; set; }
		[JsonProperty("history")] public abstract int History { get; set; }
		[JsonProperty("insight")] public abstract int? Insight { get; set; }
		[JsonProperty("intimidation")] public abstract int? Intimidation { get; set; }
		[JsonProperty("investigation")] public abstract int? Investigation { get; set; }
		[JsonProperty("medicine")] public abstract int? Medicine { get; set; }
		[JsonProperty("nature")] public abstract int? Nature { get; set; }
		[JsonProperty("perception")] public abstract int Perception { get; set; }
		[JsonProperty("performance")] public abstract int? Performance { get; set; }
		[JsonProperty("persuasion")] public abstract int? Persuasion { get; set; }
		[JsonProperty("religion")] public abstract int? Religion { get; set; }
		// sleight of hand
		[JsonProperty("stealth")] public abstract int? Stealth { get; set; }
		[JsonProperty("survival")] public abstract int? Survival { get; set; }

		[JsonProperty("strength_save")] public abstract int? StrengthSave { get; set; }
		[JsonProperty("dexterity_save")] public abstract int? DexteritySave { get; set; } 
		[JsonProperty("constitution_save")] public abstract int ConstitutionSave { get; set; }		
		[JsonProperty("intelligence_save")] public abstract int IntelligenceSave { get; set; }		
		[JsonProperty("wisdom_save")] public abstract int WisdomSave { get; set; }		
		[JsonProperty("charisma_save")] public abstract int? CharismaSave { get; set; }		
		[JsonProperty("senses")] public abstract string? Senses { get; set; }		
		[JsonProperty("languages")] public abstract string? Languages { get; set; }

    }
}
