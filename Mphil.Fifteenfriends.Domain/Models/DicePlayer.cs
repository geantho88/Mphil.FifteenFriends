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

        private readonly int _rollResult;

        private readonly int _expectedResult;

        private readonly Dictionary<int, double> _rollResultChances;

        public DicePlayer(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public DicePlayer(string firstName, string lastName, int rollResult, int expectedResult) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = LastName;
            _rollResult = rollResult;
            _expectedResult = expectedResult;
        }

        public DicePlayer(string firstName, string lastName, Dictionary<int, double> rollResultChances) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = LastName;
            _rollResultChances = rollResultChances;
        }

        public int Roll()
        {
            var rnd = new Random();

            if (_rollResult > 0 && _expectedResult > 0)
            {
                var result = rnd.Next(1, size);
                return result == _rollResult ? _expectedResult : result;
            }
            else if (_rollResultChances != null)
            {
                var numbers = _rollResultChances.Where(a => a.Value > 0.0).Select(x => x.Key).OrderBy(a => a).ToList();
                var result = numbers.OrderBy(x => rnd.Next()).FirstOrDefault();
                return result;
            }
            else
            {
                var result = rnd.Next(1, size);
                return result;
            }
        }
    }
}
