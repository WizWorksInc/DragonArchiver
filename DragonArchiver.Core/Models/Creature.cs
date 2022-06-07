namespace DragonArchiver.Core.Models
{
	/// <summary>
	/// An abstract implementation of a creature.
	/// </summary>
	public abstract class Creature
    {
		// TODO: Delete this later
        /*public abstract string Id { get; set; } 
        public abstract string Name { get; set; }
        public abstract object Type { get; set; }
        public abstract object Size { get; set; }
        public abstract object Alignment { get; set; }
        public abstract Dictionary<string, ushort> Stats { get; set; }
        public abstract ushort Speed { get; set; } // cat go nyoooom
        public abstract ushort HP { get; set; } // Health Points
        public abstract byte AC { get; set; } // Armour Class
        public abstract List<string> Languages { get; set; }
        public abstract bool CanSpeak { get; set; }
        public abstract Dictionary<string, byte> SavingThrows { get; set; }
        public abstract List<string> Conditions { get; set; }
        public abstract List<string> ConditionImmunities { get; set; }
        public abstract Dictionary<string, ushort> Senses { get; set; }
        public abstract List<string> Immunities { get; set; }
        public abstract List<string> Resistances { get; set; }
        public abstract List<string> Vulnerabilities { get; set; }
        public abstract Dictionary<string, object> Actions { get; set; }
        public abstract Dictionary<string, ushort> Perceptions { get; set; }*/

		public abstract string? Name { get; set; }
		public abstract string? Size { get; set; }
		public abstract string? Type { get; set; }
		public abstract string? Subtype { get; set; }
		public abstract string? Alignment { get; set; }
		public abstract int ArmorClass { get; set; }
		public abstract int HitPoints { get; set; }
		public abstract string? HitDice { get; set; }
		public abstract string? Speed { get; set; }
		public abstract int Strength { get; set; }
		public abstract int Dexterity { get; set; }
		public abstract int Constitution { get; set; }
		public abstract int Intelligence { get; set; }
		public abstract int Wisdom { get; set; }
		public abstract int Charisma { get; set; }
		public abstract int? Acrobatics { get; set; }
		// animal handling
		public abstract int? Arcana { get; set; }
		public abstract int? Athletics { get; set; }
		public abstract int? Deception { get; set; }
		public abstract int History { get; set; }
		public abstract int? Insight { get; set; }
		public abstract int? Intimidation { get; set; }
		public abstract int? Investigation { get; set; }
		public abstract int? Medicine { get; set; }
		public abstract int? Nature { get; set; }
		public abstract int Perception { get; set; }
		public abstract int? Performance { get; set; }
		public abstract int? Persuasion { get; set; }
		public abstract int? Religion { get; set; }
		// sleight of hand
		public abstract int? Stealth { get; set; }
		public abstract int? Survival { get; set; }

		public abstract int? StrengthSave { get; set; }
		public abstract int? DexteritySave { get; set; } 
		public abstract int ConstitutionSave { get; set; }		
		public abstract int IntelligenceSave { get; set; }		
		public abstract int WisdomSave { get; set; }		
		public abstract int? CharismaSave { get; set; }		
		public abstract string? Senses { get; set; }		
		public abstract string? Languages { get; set; }

    }
}
