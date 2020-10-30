using Mphil.Fifteenfriends.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mphil.Fifteenfriends.Domain.Models
{
    public class Two5DicePlayer : Person, IDicePlayer
    {
        private static readonly int size = 6;

        public Two5DicePlayer(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = LastName;
        }

        public int Roll()
        {
            var rnd = new Random();
            var result = rnd.Next(size);
            return result == 3 ? 5 : result;
        }
    }
}
