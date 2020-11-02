using Mphil.Fifteenfriends.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Domain.Models
{
    public class CardPlayer : Person, ICardPlayer
    {
        private IList<Card> _cards = new List<Card>();

        public CardPlayer(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = LastName;
        }

        public List<Card> OpenCards()
        {
            return _cards.ToList();
        }

        public void PickCard(Deck deck)
        {
            _cards.Add(deck.pickCard());
        }

        public List<Card> CardsInHand(List<Card> cards)
        {
            return _cards.ToList();
        }
    }
}
