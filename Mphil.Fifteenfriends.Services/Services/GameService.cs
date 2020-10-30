﻿using Mphil.Fifteenfriends.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Services.Services
{
    public class GameService : IGameService
    {
        private readonly List<Person> _players;

        public GameService()
        {
            _players = new List<Person>();
        }

        public void CreateCardPlayers(int number)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    _players.Add(new CardPlayer($"Card Player", $" #{i}"));
                }
            }
        }

        public void CreateDicePlayers(int number)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    _players.Add(new DicePlayer($"Dice Player", $" #{i}"));
                }
            }
        }

        public void CreateCardDicePlayers(int number)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    _players.Add(new CardDicePlayer($"Card Dice Player", $" #{i}"));
                }
            }
        }

        public void CreateTwo5CardDicePlayers(int number)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    _players.Add(new Two5CardDicePlayer($"Two 5Card Dice Player", $" #{i}"));
                }
            }
        }

        public void CreateTwo6CardDicePlayer(int number)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    _players.Add(new Two5CardDicePlayer($"Two 6Card Dice Player", $" #{i}"));
                }
            }
        }

        public void CreateTwo5DicePlayer(int number)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    _players.Add(new Two5CardDicePlayer($"Two 5Dice Player", $" #{i}"));
                }
            }
        }

        public void CreateTwo6DicePlayer(int number)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    _players.Add(new Two5CardDicePlayer($"Two 6Dice Player", $" #{i}"));
                }
            }
        }

        public bool CanStartGame()
        {
            return _players.Any() && _players.Count <= 15;
        }

        public void ClearPlayers()
        {
            _players.Clear();
        }

        public List<Person> GetPlayers()
        {
            return _players;
        }
    }
}
