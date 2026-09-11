using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventures_Guild.Commissions;

namespace Adventures_Guild.Characters
{
    public class CryoCharacter : Character, IDamageDealer
    {
        public int FreezePower { get; private set; }

        public CryoCharacter(string name, int ascension)
        : base(name, ascension)
        {
        }

        public override void UseElementalSkill(Commission commission)
        {
            int freezeDuration = FreezePower + Ascension;

            Console.WriteLine();
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"{Name} uses their Cryo skill!");
            Console.WriteLine($"Freeze duration: {freezeDuration} seconds");
            Console.WriteLine($"Required duration: {commission.RequiredFreezeTime} seconds");

            if (freezeDuration >= commission.RequiredFreezeTime)
            {
                Console.WriteLine("The target stays frozen long enough!");
            }
            else
            {
                Console.WriteLine("The ice melts too quickly!");
            }
        }

        public int Attack()
        {
            int damage = FreezePower + Ascension;

            return damage;
        }
    }
}
