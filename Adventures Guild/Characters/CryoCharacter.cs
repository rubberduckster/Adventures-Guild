using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Characters
{
    public class CryoCharacter : Character, IDamageDealer
    {
        public CryoCharacter(string name, int ascension)
        : base(name, ascension)
        {
        }

        public override void UseElementalSkill()
        {
            Console.WriteLine($"{Name} uses a freezing Cryo skill.");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks the enemy.");
        }
    }
}
