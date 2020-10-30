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

        public DicePlayer(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = LastName;
        }

        public int Roll()
        {
            var rnd = new Random();
            return rnd.Next(size);
        }
    }
}
