using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArchiver.Core.Model
{
    internal class Player : Creature, ILocations, IClassable
    {
        public override string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override object Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override object Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override object Alignment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Dictionary<string, ushort> Stats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ushort Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ushort HP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override byte AC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override List<string> Languages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool CanSpeak { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Dictionary<string, byte> SavingThrows { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override List<string> Conditions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override List<string> ConditionImmunities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Dictionary<string, ushort> Senses { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override List<string> Immunities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override List<string> Resistances { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override List<string> Vulnerabilities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Dictionary<string, object> Actions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Dictionary<string, ushort> Perceptions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CurrentLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HomeLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
