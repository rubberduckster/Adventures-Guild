using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventures_Guild.Commissions;

namespace Adventures_Guild.Characters
{
    public class DendroCharacter : Character, IHealer
    {
        public int LifePower { get; private set; }

        public DendroCharacter(string name, int ascension, int lifePower)
        : base(name, ascension)
        {
            LifePower = lifePower;
        }

        public override void UseElementalSkill(Commission commission)
        {
            int growthPower = LifePower + Ascension;

            Console.WriteLine();
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"{Name} uses their Dendro skill!");
            Console.WriteLine($"Growth power: {growthPower}");
            Console.WriteLine($"Required growth: {commission.RequiredGrowth}");

            if (growthPower >= commission.RequiredGrowth)
            {
                Console.WriteLine("The plants grow successfully!");
            }
            else
            {
                Console.WriteLine("The plants do not grow enough!");
            }
        }

        public void Heal()
        {
            Console.WriteLine($"{Name} heals an ally.");
        }
    }
}
