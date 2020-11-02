using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Mphil.Fifteenfriends.Domain.Models;
using Mphil.Fifteenfriends.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.FifteenFriends.Tests
{

    [TestClass]
    public class PlayersTests
    {
        private CardPlayer _cardPlayer;
        private DicePlayer _dicePlayer;
        private CardDicePlayer _cardDicePlayer;
        private IDeckersMeeting _deckersMeeting;

        [TestInitialize]
        public void testInit()
        {
            _cardPlayer = new CardPlayer("test first name", "test last name");
            _dicePlayer = new DicePlayer("test first name", "test last name", 4, 6);
            _cardDicePlayer = new CardDicePlayer("test first name", "test last name");

            _deckersMeeting = new DeckersMeeting();
        }

        [TestMethod]
        public void DicePlayer_Can_Roll()
        {
            var result = _deckersMeeting.Roll(_dicePlayer);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DicePlayer_Roll_Result_Is_Never_Four()
        {
            var result = _deckersMeeting.Roll(_dicePlayer);
            Assert.IsTrue(result != 4);
        }


        [TestMethod]
        public void CardPlayer_Can_PickCard()
        {
            _deckersMeeting.PickCard(_cardPlayer);
            Assert.IsTrue(_cardPlayer.OpenCards().Any());
        }

        [TestMethod]
        public void CardDicePlayer_Can_PickCard_And_Roll()
        {
            _deckersMeeting.PickCard(_cardDicePlayer);
            var rollResult = _deckersMeeting.Roll(_cardDicePlayer);

            Assert.IsTrue(_cardDicePlayer.OpenCards().Any());
            Assert.IsTrue(rollResult > 0);
        }
    }
}
