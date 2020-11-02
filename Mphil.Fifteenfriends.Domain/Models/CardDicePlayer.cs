using Mphil.Fifteenfriends.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Domain.Models
{
    public class CardDicePlayer : Person, ICardPlayer, IDicePlayer
    {
        private readonly int size = 6;
        private IList<Card> _cards = new List<Card>();

        public CardDicePlayer(string firstName, string lastName) : base(firstName, lastName)
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

        public int Roll()
        {
            var rnd = new Random();
            return rnd.Next(1,size);
        }
    }
}
