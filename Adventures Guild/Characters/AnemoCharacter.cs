using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventures_Guild.Commissions;

namespace Adventures_Guild.Characters
{
    public class AnemoCharacter : Character
    {
        public int WindPower { get; private set; }

        public AnemoCharacter(string name, int ascension, int windPower)
        : base(name, ascension, ElementType.Anemo)
        {
            WindPower = windPower;
        }

        public override void UseElementalSkill(Commission commission)
        {
            int liftCapacity = WindPower * Ascension;

            Console.WriteLine();
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"{Name} uses their Anemo skill!");
            Console.WriteLine($"Lifting power: {liftCapacity}");
            Console.WriteLine($"Required lifting power: {commission.RequiredWeight}");

            if (liftCapacity >= commission.RequiredWeight)
            {
                Console.WriteLine("Object successfully lifted!");
            }
            else
            {
                Console.WriteLine("The object is too heavy!");
            }
        }
    }
}
