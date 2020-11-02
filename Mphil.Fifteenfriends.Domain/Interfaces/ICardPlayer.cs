using Mphil.Fifteenfriends.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Domain.Interfaces
{
    public interface ICardPlayer
    {
        List<Card> OpenCards();
        void PickCard(Deck deck);
        List<Card> CardsInHand(List<Card> cards);
    }
}
