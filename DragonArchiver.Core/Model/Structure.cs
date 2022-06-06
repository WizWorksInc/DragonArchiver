namespace DragonArchiver.Core.Model
{
    internal abstract class Structure : ILocation
    {

        public string CurrentLocation { get; set; }
        public string HomeLocation { get; set; }

    }
}
