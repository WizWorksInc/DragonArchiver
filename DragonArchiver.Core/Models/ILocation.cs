namespace DragonArchiver.Core.Models
{
    internal interface ILocation
    {
        // starting the process of building this out
        public string? CurrentLocation { get; set; }
        public string? HomeLocation { get; set; }
    }
}
