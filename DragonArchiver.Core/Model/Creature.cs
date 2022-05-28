namespace DragonArchiver.Core.Model
{
    internal abstract class Creature
    {
        public abstract string Id { get; set; }
        public abstract string Name { get; set; }
        public abstract object Type { get; set; }
        public abstract object Size { get; set; }
        public abstract object Alignment { get; set; }
        public abstract Dictionary<string, ushort> Stats { get; set; }
        public abstract ushort Speed { get; set; } // cat go nyoooom
        public abstract ushort HP { get; set; } // Health Points
        // TODO: Look into ac more as the data type may have to change at a later date
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
        public abstract Dictionary<string, ushort> Perceptions { get; set; }

    }
}
