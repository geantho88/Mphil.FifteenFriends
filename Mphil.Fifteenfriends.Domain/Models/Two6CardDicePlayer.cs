using Mphil.Fifteenfriends.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Domain.Models
{
    public class Two6CardDicePlayer : Two6DicePlayer, ICardPlayer
    {
        public Two6CardDicePlayer(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = LastName;
        }

        public List<Card> CardsInHand(List<Card> cards)
        {
            return CardsInHand(cards);
        }

        public List<Card> OpenCards(List<Card> cards)
        {
            return OpenCards(cards);
        }

        public void PickCard(Deck deck)
        {
            PickCard(deck);
        }
    }
}
