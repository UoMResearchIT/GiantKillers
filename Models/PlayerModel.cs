using System;
using System.Collections.Generic;
using System.Text;

namespace GiantKillers.Models
{
    class PlayerModel
    {
        public int PlayerNumber { get; }

        public string Name { get; }

        public int NumberOfGiantKillerCards { get; }

        public PlayerModel(int number, string name)
        {
            PlayerNumber = number;
            Name = name;
        }
    }
}
