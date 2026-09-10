using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Characters
{
    public class PyroCharacter : Character, IDamageDealer
    {
        public int BurningPower { get; private set; }

        public PyroCharacter(string name, int ascension, int burningPower) 
        : base(name, ascension)
        {
            BurningPower = burningPower;
        }

        public int GetBurnPower()
        {
            return BurningPower * Ascension;
        }

        public override void UseElementalSkill()
        {
            Console.WriteLine($"{Name} actives their skill and does {GetBurnPower()} burn.");
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks the enemy.");
        }
    }
}
