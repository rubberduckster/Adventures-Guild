using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Characters
{
    public class GeoCharacter : Character, IShielder
    {
        public GeoCharacter(string name, int ascension)
            : base(name, ascension)
        {
        }

        public override void UseElementalSkill()
        {
            Console.WriteLine($"{Name} uses their Geo elemental skill.");
        }

        public void CreateShield()
        {
            Console.WriteLine($"{Name} creates a shield.");
        }
    }
}
