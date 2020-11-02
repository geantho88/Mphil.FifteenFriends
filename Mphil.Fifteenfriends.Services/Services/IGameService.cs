using Mphil.Fifteenfriends.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Services.Services
{
    public interface IGameService
    {
        void CreateCardPlayers(int number);
        void CreateDicePlayers(int number);
        void CreateCardDicePlayers(int number);
        void CreateTwo5CardDicePlayers(int number);
        void CreateTwo6CardDicePlayer(int number);
        void CreateTwo5DicePlayer(int number);
        void CreateTwo6DicePlayer(int number);
        bool CanStartGame();
        void ClearPlayers();
        List<Person> GetPlayers();
        int GetRemainingCards();
        void PickCard(CardPlayer player);
        int Roll(DicePlayer player);
    }
}
