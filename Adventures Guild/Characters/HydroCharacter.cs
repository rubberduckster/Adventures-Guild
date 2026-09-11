using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventures_Guild.Commissions;

namespace Adventures_Guild.Characters
{
    public class HydroCharacter : Character, IHealer
    {
        public int LifePower { get; private set; }

        public HydroCharacter(string name, int ascension, int lifePower)
        : base(name, ascension, ElementType.Hydro)
        {
            LifePower = lifePower;
        }

        public override void UseElementalSkill(Commission commission)
        {
            int missingHealth = commission.MaxHealth - commission.CurrentHealth;
            int healingAmount = LifePower * Ascension;

            if (healingAmount > missingHealth)
            {
                healingAmount = missingHealth;
            }

            commission.CurrentHealth += healingAmount;

            Console.WriteLine();
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"{Name} uses their Hydro skill!");
            Console.WriteLine($"Healing power: {healingAmount}");
            Console.WriteLine(
                $"Health restored: {commission.CurrentHealth}/{commission.MaxHealth}"
            );
        }

        public void Heal()
        {
            Console.WriteLine($"{Name} heals an ally.");
        }
    }
}
