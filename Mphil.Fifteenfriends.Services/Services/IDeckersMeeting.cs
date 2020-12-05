using Mphil.Fifteenfriends.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Services.Services
{
    public interface IDeckersMeeting
    {
        void CreateCardPlayers(int number);
        void CreateCardDicePlayers(int number, Dictionary<int, double> rollResultChances);
        void CreateDicePlayers(int number, int rollResult, int expectedResult);
        void CreateDicePlayers(int number, Dictionary<int, double> rollResultChances);
        void ShuffleDeck();
        bool CanStartGame();
        void ClearPlayers();
        List<Person> GetPlayers();
        int GetRemainingCards();
        void PickCard(CardPlayer player);
        void PickCard(CardDicePlayer player);
        int Roll(DicePlayer player);
        int Roll(CardDicePlayer player);
    }
}
