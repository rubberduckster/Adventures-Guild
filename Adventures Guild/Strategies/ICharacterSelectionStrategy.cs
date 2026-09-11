using Adventures_Guild.Characters;
using Adventures_Guild.Commissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventures_Guild.Strategies
{
    public interface ICharacterSelectionStrategy
    {
        Character SelectCharacter(Commission commission, List<Character> availableCharacters);
    }
}
