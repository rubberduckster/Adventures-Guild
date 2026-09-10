using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Characters
{
    public abstract class Character
    {
        public string Name { get; }
        public int Ascension { get; }
        public bool IsAvailable { get; private set; }

        public Character(string name, int ascension)
        {
            Name = name;
            Ascension = ascension;
            IsAvailable = true;
        }

        public abstract void UseElementalSkill();

        public void SetUnavailable()
        {
            IsAvailable = false;
        }

        public void SetAvailable()
        {
            IsAvailable = true;
        }
    }
}
