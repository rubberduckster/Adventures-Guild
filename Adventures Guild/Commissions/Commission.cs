using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Commissions
{
    public class Commission
    {
        public string Name { get; }
        public string Description { get; }
        public string Location { get; }
        public CommissionDifficulty Difficulty { get; }
        public int Reward { get; }
        public bool IsCompleted { get; private set; }

        // Pyro
        public int BaseTime { get; set; }

        // Anemo
        public int RequiredWeight { get; set; }

        // Cryo
        public int RequiredFreezeTime { get; set; }

        // Hydro
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }

        // Dendro
        public int RequiredGrowth { get; set; }

        // Geo
        public int IncomingDamage { get; set; }

        // Electro
        public int RequiredEnergy { get; set; }

        public Commission(string name, string description, string location, CommissionDifficulty difficulty,int reward)
        {
            Name = name;
            Description = description;
            Location = location;
            Difficulty = difficulty;
            Reward = reward;
            IsCompleted = false;
        }

        public void Complete()
        {
            IsCompleted = true;
        }
    }
}
