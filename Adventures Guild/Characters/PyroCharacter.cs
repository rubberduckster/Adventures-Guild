using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventures_Guild.Commissions;

namespace Adventures_Guild.Characters
{
    public class PyroCharacter : Character, IDamageDealer
    {
        public int BurningPower { get; private set; }

        public PyroCharacter(string name, int ascension, int burningPower) 
        : base(name, ascension, ElementType.Pyro)
        {
            BurningPower = burningPower;
        }

        public override void UseElementalSkill(Commission commission)
        {
            int skillPower = BurningPower + Ascension;
            int actualTime = commission.BaseTime / skillPower;

            Console.WriteLine();
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"{Name} uses their Pyro skill!");
            Console.WriteLine($"Burning power: {skillPower}");
            Console.WriteLine($"Completed in: {actualTime} seconds");
        }

        public int Attack()
        {
            int damage = BurningPower + Ascension;

            return damage;
        }
    }
}
