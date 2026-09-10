using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Characters
{
    public class HydroCharacter : Character, IHealer
    {
        public HydroCharacter(string name, int ascension)
            : base(name, ascension)
        {
        }

        public override void UseElementalSkill()
        {
            Console.WriteLine($"{Name} uses a Hydro skill.");
        }

        public void Heal()
        {
            Console.WriteLine($"{Name} heals an ally.");
        }
    }
}
