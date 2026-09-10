using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Characters
{
    public class ElectroCharacter : Character, ISupport
    {
        public ElectroCharacter(string name, int ascension)
            : base(name, ascension)
        {
        }

        public override void UseElementalSkill()
        {
            Console.WriteLine($"{Name} uses their Electro elemental skill.");
        }

        public void Support()
        {
            Console.WriteLine($"{Name} supports the party.");
        }
    }
}
