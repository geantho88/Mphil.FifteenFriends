using Mphil.Fifteenfriends.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Domain.Models
{
    public class Card
    {
        private readonly Suit _suit;
        private readonly CardRank _cardRank;

        public Card(CardRank cardRank, Suit suit)
        {
            _cardRank = cardRank;
            _suit = suit;
        }

        public CardRank CardRank { get; set; }
        public Suit Suit { get; set; }

        public override string ToString()
        {
            return $"{_cardRank} {_suit}";
        }
    }
}
