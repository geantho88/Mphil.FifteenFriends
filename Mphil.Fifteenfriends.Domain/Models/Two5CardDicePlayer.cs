using Mphil.Fifteenfriends.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Domain.Models
{
    public class Two5CardDicePlayer : Two5DicePlayer, ICardPlayer
    {
        public Two5CardDicePlayer(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = LastName;
        }

        public List<Card> CardsInHand(List<Card> cards)
        {
            return CardsInHand(cards);
        }

        public List<Card> OpenCards()
        {
            return OpenCards();
        }

        public void PickCard(Deck deck)
        {
            PickCard(deck);
        }
    }
}
