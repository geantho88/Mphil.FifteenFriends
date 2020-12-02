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
        private DicePlayer _dicePlayerWithFixedChances;
        private DicePlayer _dicePlayerWithRollChances;
        private DicePlayer _dicePlayerWithInvalidRollChances;
        private CardDicePlayer _cardDicePlayer;
        private IDeckersMeeting _deckersMeeting;
        private Dictionary<int, double> _rollResultChances;
        private Dictionary<int, double> _invalidResultChances;

        [TestInitialize]
        public void testInit()
        {
            _rollResultChances = new Dictionary<int, double>();
            _invalidResultChances = new Dictionary<int, double>();

            //Initialize the rollChances
            _rollResultChances.Add(1, 0.0);
            _rollResultChances.Add(2, 0.2);
            _rollResultChances.Add(3, 0.3);
            _rollResultChances.Add(4, 0.5);
            _rollResultChances.Add(5, 0.0);
            _rollResultChances.Add(6, 0.2);

            _invalidResultChances.Add(7, 0.5);
            _invalidResultChances.Add(8, 0.2);
            _invalidResultChances.Add(9, 0.3);

            _cardPlayer = new CardPlayer("test first name", "test last name");
            _dicePlayerWithFixedChances = new DicePlayer("test first name", "test last name", 4, 6);
            _dicePlayerWithRollChances = new DicePlayer("Nick", "Taramas", _rollResultChances);
            _dicePlayerWithInvalidRollChances = new DicePlayer("Nick", "Taramas", _invalidResultChances);
            _cardDicePlayer = new CardDicePlayer("test first name", "test last name");

            _deckersMeeting = new DeckersMeeting();
        }

        [TestMethod]
        public void DicePlayer_Can_Roll()
        {
            var result = _deckersMeeting.Roll(_dicePlayerWithFixedChances);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void DicePlayer_Roll_Result_Is_Never_Four()
        {
            var result = _deckersMeeting.Roll(_dicePlayerWithFixedChances);
            Assert.IsTrue(result != 4);
        }

        [TestMethod]
        public void DicePlayer_WithRollChances_Can_Roll()
        {
            var result = _deckersMeeting.Roll(_dicePlayerWithRollChances);
            Assert.IsTrue(result > 0 && result <= 6);
        }

        [TestMethod]
        public void DicePlayer_With_InvalidRollChances_Can_Roll()
        {
            var result = _deckersMeeting.Roll(_dicePlayerWithInvalidRollChances);
            Assert.IsTrue(result > 0 && result <= 6);
            //Assert.ThrowsException<RollResultChanceException>(() => _deckersMeeting.Roll(_dicePlayerWithInvalidRollChances), "Roll Result Keys should be greater than zero and less or equal than 6");
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
