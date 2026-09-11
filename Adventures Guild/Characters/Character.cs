using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventures_Guild.Commissions;

namespace Adventures_Guild.Characters
{
    public abstract class Character
    {
        public string Name { get; }
        public int Ascension { get; }
        public bool IsAvailable { get; private set; }
        public int Wallet { get; private set; }
        public int CommissionsCompleted { get; private set; }
        public int RestCounter { get; private set; }

        public Character(string name, int ascension)
        {
            Name = name;
            Ascension = ascension;
            IsAvailable = true;
            Wallet = 0;
            CommissionsCompleted = 0;
            RestCounter = 0;
        }

        public abstract void UseElementalSkill(Commission commission);

        public void CompleteCommission(int reward)
        {
            Wallet += reward;
            CommissionsCompleted++;
        }

        public void StartRest(int restAmount)
        {
            RestCounter = restAmount;
            IsAvailable = false;
        }

        public void ReduceRest()
        {
            if (RestCounter > 0)
            {
                RestCounter--;
            }

            if (RestCounter == 0)
            {
                IsAvailable = true;
            }
        }
    }
}
