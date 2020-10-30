using Mphil.Fifteenfriends.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Domain.Models
{
    public class Deck
    {
        private readonly IList<Card> _decks;
        private int _top = 0;

        public Deck()
        {
            _decks = new List<Card>(52);

            foreach (var cardRank in (CardRank[])Enum.GetValues(typeof(CardRank)))
            {
                foreach (var suit in (Suit[])Enum.GetValues(typeof(Suit)))
                {
                    _decks.Add(new Card(cardRank, suit));
                }
            }
        }

        //Generics in C# do no contain a shuffle method so what we can do is order the list by a new Guid using Linq.
        public void shuffle()
        {
            if (_decks.Any())
            {
                _decks.OrderBy(a => Guid.NewGuid()).ToList();
            }

            throw new NullReferenceException();
        }

        public bool empty()
        {
            return !_decks.Any();
        }

        public Card pickCard()
        {
            if (_decks.Any())
            {
                var card = _decks.FirstOrDefault();
                _decks.Remove(card);

                return card;
            }

            throw new NullReferenceException();
        }
    }
}
