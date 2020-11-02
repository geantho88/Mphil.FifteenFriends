using Mphil.Fifteenfriends.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Domain.Models
{
    public class DicePlayer : Person, IDicePlayer
    {
        private static readonly int size = 6;
        public int RollResult { get; set; }
        public int ExpectedResult { get; set; }

        public DicePlayer(string firstName, string lastName, int rollResult, int expectedResult) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = LastName;
            RollResult = rollResult;
            ExpectedResult = expectedResult;
        }

        public int Roll()
        {
            var rnd = new Random();
            var result = rnd.Next(1,size);
            return result == RollResult ? ExpectedResult : result;
        }
    }
}
