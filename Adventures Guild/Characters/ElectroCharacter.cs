using Adventures_Guild.Commissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Characters
{
    public class ElectroCharacter : Character
    {
        public int EnergyPower { get; private set; }

        public ElectroCharacter(string name, int ascension, int energyPower)
        : base(name, ascension)
        {
            EnergyPower = energyPower;
        }

        public override void UseElementalSkill(Commission commission)
        {
            int energyPerCharge = EnergyPower + Ascension;

            int chargesNeeded =
                (int)Math.Ceiling(
                    (double)commission.RequiredEnergy / energyPerCharge
                );

            Console.WriteLine();
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"{Name} uses their Electro skill!");
            Console.WriteLine($"Energy per charge: {energyPerCharge}");
            Console.WriteLine($"Energy required: {commission.RequiredEnergy}");
            Console.WriteLine($"Charges needed: {chargesNeeded}");
        }
    }
}
