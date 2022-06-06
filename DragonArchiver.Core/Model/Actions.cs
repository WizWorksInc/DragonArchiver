namespace DragonArchiver.Core.Model
{
    public class Action
    {
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public int AttackBonus { get; set; }
        public string? DamageDice { get; set; }
        public int? DamageBonus { get; set; }
    }

    public class LegendaryAction
    {
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public int AttackBonus { get; set; }
        public string? DamageDice { get; set; }
    }

    public class Reaction
    {
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public int AttackBonus { get; set; }
    }
}
