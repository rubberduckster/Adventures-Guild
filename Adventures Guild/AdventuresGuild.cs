using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventures_Guild.Characters;
using Adventures_Guild.Commissions;
using Adventures_Guild.Exceptions;
using Adventures_Guild.Exceptions.Adventures_Guild.Exceptions;
using Adventures_Guild.Strategies;

namespace Adventures_Guild
{
    public class AdventurersGuild
    {
        private List<Character> characters;
        private List<Commission> commissions;

        private ICharacterSelectionStrategy selectionStrategy;

        public AdventurersGuild(ICharacterSelectionStrategy selectionStrategy)
        {
            characters = new List<Character>();
            commissions = new List<Commission>();

            this.selectionStrategy = selectionStrategy;
        }

        public void AddCharacter(Character character)
        {
            characters.Add(character);
        }

        public void AddCommission(Commission commission)
        {
            commissions.Add(commission);
        }

        public Character SelectCharacter(Commission commission)
        {
            return selectionStrategy.SelectCharacter(commission, characters);
        }

        public void AssignCharacter(Character character, Commission commission)
        {
            if (!character.IsAvailable)
            {
                throw new CharacterUnavailableException(
                    $"{character.Name} is currently unavailable."
                );
            }

            character.UseElementalSkill(commission);
        }

        private void UpdateRestCounters()
        {
            foreach (Character character in characters)
            {
                character.ReduceRest();
            }
        }

        public void CompleteCommission(Commission commission, Action<Commission> onCompleted)
        {
            Character character = selectionStrategy.SelectCharacter(commission, characters);

            if (character == null)
            {
                throw new NoSuitableCharacterException(
                    "No suitable character is available."
                );
            }

            character.UseElementalSkill(commission);

            commission.Complete();

            character.CompleteCommission(commission.Reward);

            UpdateRestCounters();

            character.StartRest(2);

            onCompleted(commission);
        }
    }
}
