﻿using Mphil.Fifteenfriends.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Services.Services
{
    public class DeckersMeeting : IDeckersMeeting
    {
        private readonly List<Person> _players;
        public Deck deck;

        public DeckersMeeting()
        {
            _players = new List<Person>();
            deck = new Deck();
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

        public void CreateDicePlayers(int number, Dictionary<int, double> rollResultChances)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    _players.Add(new DicePlayer($"Dice Player", $" #{i}", rollResultChances));
                }
            }
        }

        public void CreateDicePlayers(int number, int rollResult, int expectedResult)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    _players.Add(new DicePlayer($"Dice Player", $" #{i}", rollResult, expectedResult));
                }
            }
        }

        public void CreateCardDicePlayers(int number, Dictionary<int, double> rollResultChances)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    _players.Add(new CardDicePlayer($"Card Dice Player", $" #{i}", rollResultChances));
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

        public void ShuffleDeck()
        {
            deck.shuffle();
        }

        public int GetRemainingCards()
        {
            return deck.GetRemainingCards();
        }

        public void PickCard(CardPlayer player)
        {
            player.PickCard(deck);
        }

        public void PickCard(CardDicePlayer player)
        {
            player.PickCard(deck);
        }

        public int Roll(DicePlayer player)
        {
            return player.Roll();
        }

        public int Roll(CardDicePlayer player)
        {
            return player.Roll();
        }
    }
}
