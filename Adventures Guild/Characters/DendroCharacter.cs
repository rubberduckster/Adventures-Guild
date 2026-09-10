using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Characters
{
    public class DendroCharacter : Character, IHealer
    {
        public DendroCharacter(string name, int ascension)
            : base(name, ascension)
        {
        }

        public override void UseElementalSkill()
        {
            Console.WriteLine($"{Name} uses their Dendro elemental skill.");
        }

        public void Heal()
        {
            Console.WriteLine($"{Name} heals an ally.");
        }
    }
}
