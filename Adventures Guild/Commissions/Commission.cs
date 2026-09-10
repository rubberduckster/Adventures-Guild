using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Commissions
{
    public class Commission
    {
        public string Name { get; set; }
        public CommissionDifficulty Difficulty { get; set; }
        public int BaseTime { get; set; }
        public int RequiredWeight { get; set; }
        public int RequiredFreezeTime { get; set; }

        public int Reward { get; set; }
        public Commission(string name, CommissionDifficulty difficulty, int reward)
        {
            Name = name;
            Difficulty = difficulty;
            Reward = reward;
        }
    }
}
