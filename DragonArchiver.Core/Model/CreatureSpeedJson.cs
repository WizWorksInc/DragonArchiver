namespace DragonArchiver.Core.Model;

public class CreatureSpeedJson
{
	public int Walk { get; set; }
	public int Swim { get; set; }
	public int? Fly { get; set; }
	public int? Burrow { get; set; }
	public int? Climb { get; set; }
	public bool? Hover { get; set; }
	public string? Notes { get; set; }
}