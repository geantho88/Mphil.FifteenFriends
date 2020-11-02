using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mphil.Fifteenfriends.Services.Services;

namespace Mphil.FifteenFriends.Tests
{
    [TestClass]
    public class GameServiceTests
    {
        private IDeckersMeeting _deckersMeeting;

        [TestInitialize]
        public void testInit()
        {
            _deckersMeeting = new DeckersMeeting();
        }

        [TestMethod]
        public void Can_Create_Game_With_CardPlayers()
        {
            _deckersMeeting.CreateCardPlayers(4);
            var _cardPlayers = _deckersMeeting.GetPlayers();
            Assert.IsTrue(_cardPlayers.Any());
        }


        [TestMethod]
        public void Can_Create_Game_With_DicePlayers()
        {
            _deckersMeeting.CreateDicePlayers(4);
            var _dicePayers = _deckersMeeting.GetPlayers();
            Assert.IsTrue(_dicePayers.Any());
        }

        [TestMethod]
        public void Can_Create_Game_With_Deck()
        {
            var deckCardsNumber = _deckersMeeting.GetRemainingCards();
            Assert.IsTrue(deckCardsNumber > 1);
        }

        [TestMethod]
        public void Can_Not_Create_Game_With_More_Than_15_players()
        {
            _deckersMeeting.CreateDicePlayers(24);
            Assert.IsTrue(_deckersMeeting.CanStartGame() == false);
        }

        [TestMethod]
        public void Can_Shuffle_Deck()
        {
            _deckersMeeting.ShuffleDeck();
        }
    }
}
