using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventures_Guild.Commissions;

namespace Adventures_Guild.Characters
{
    public class GeoCharacter : Character, IShielder
    {
        public int ShieldPower { get; private set; }

        public GeoCharacter(string name, int ascension, int shieldPower)
        : base(name, ascension, ElementType.Geo)
        {
            ShieldPower = shieldPower;
        }

        public override void UseElementalSkill(Commission commission)
        {
            int shieldStrength = ShieldPower + Ascension;
            int remainingDamage = commission.IncomingDamage - shieldStrength;

            Console.WriteLine();
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"{Name} uses their Geo skill!");
            Console.WriteLine($"Shield strength: {shieldStrength}");
            Console.WriteLine($"Incoming damage: {commission.IncomingDamage}");

            if (remainingDamage <= 0)
            {
                Console.WriteLine("The shield blocks all incoming damage!");
            }
            else
            {
                Console.WriteLine(
                    $"The shield breaks and {remainingDamage} damage gets through!"
                );
            }
        }
    }
}
