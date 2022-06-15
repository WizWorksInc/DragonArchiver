using System.Text.Json.Serialization;

namespace DragonArchiver.Core.Models
{
    public class Action
    {
        [JsonPropertyName("name")] public string? Name { get; set; }
        [JsonPropertyName("desc")] public string? Desc { get; set; }
        [JsonPropertyName("attack_bonus")] public int AttackBonus { get; set; }
        [JsonPropertyName("damage_dice")] public string? DamageDice { get; set; }
        [JsonPropertyName("damage_bonus")] public int? DamageBonus { get; set; }
    }

    public class LegendaryAction
    {
        [JsonPropertyName("name")] public string? Name { get; set; }
        [JsonPropertyName("desc")] public string? Desc { get; set; }
        [JsonPropertyName("attack_bonus")] public int AttackBonus { get; set; }
        [JsonPropertyName("damage_dice")] public string? DamageDice { get; set; }
    }

    public class Reaction
    {
        [JsonPropertyName("name")] public string? Name { get; set; }
        [JsonPropertyName("desc")] public string? Desc { get; set; }
        [JsonPropertyName("attack_bonus")] public int AttackBonus { get; set; }
    }
}
