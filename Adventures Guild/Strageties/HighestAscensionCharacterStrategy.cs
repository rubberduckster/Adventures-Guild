using Adventures_Guild.Characters;
using Adventures_Guild.Commissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Strageties
{
    public class HighestAscensionCharacterStrategy: ICharacterSelectionStrategy
    {
        public Character SelectCharacter(Commission commission, List<Character> availableCharacters)
        {
            Character selectedCharacter = null;

            foreach (Character character in availableCharacters)
            {
                if (!character.IsAvailable)
                {
                    continue;
                }

                if (selectedCharacter == null ||
                    character.Ascension > selectedCharacter.Ascension)
                {
                    selectedCharacter = character;
                }
            }

            return selectedCharacter;
        }
    }
}
