namespace DragonArchiver.Core.Models
{
    internal interface ILocation
    {
        public string? CurrentLocation { get; set; }
        public string? HomeLocation { get; set; }
    }
}
