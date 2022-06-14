using Newtonsoft.Json;

namespace DragonArchiver.Core.Models
{
    public class Action
    {
        [JsonProperty("name")] public string? Name { get; set; }
        [JsonProperty("desc")] public string? Desc { get; set; }
        [JsonProperty("attack_bonus")] public int AttackBonus { get; set; }
        [JsonProperty("damage_dice")] public string? DamageDice { get; set; }
        [JsonProperty("damage_bonus")] public int? DamageBonus { get; set; }
    }

    public class LegendaryAction
    {
        [JsonProperty("name")] public string? Name { get; set; }
        [JsonProperty("desc")] public string? Desc { get; set; }
        [JsonProperty("attack_bonus")] public int AttackBonus { get; set; }
        [JsonProperty("damage_dice")] public string? DamageDice { get; set; }
    }

    public class Reaction
    {
        [JsonProperty("name")] public string? Name { get; set; }
        [JsonProperty("desc")] public string? Desc { get; set; }
        [JsonProperty("attack_bonus")] public int AttackBonus { get; set; }
    }
}
