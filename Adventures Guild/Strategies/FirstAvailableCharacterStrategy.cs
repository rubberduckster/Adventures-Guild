using Adventures_Guild.Characters;
using Adventures_Guild.Commissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Strategies
{
    public class FirstAvailableCharacterStrategy : ICharacterSelectionStrategy
    {
        public Character SelectCharacter(Commission commission, List<Character> availableCharacters)
        {
            foreach (Character character in availableCharacters)
            {
                if (character.IsAvailable)
                {
                    return character;
                }
            }

            return null;
        }
    }
}
