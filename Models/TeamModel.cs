using System;
using GiantKillers.Enums;
using NodaMoney;

namespace GiantKillers.Models
{
    public class TeamModel
    {
        public string Name { get; }

        public Category Category { get; }

        public Money GateValue { get; }

        public int GroundCapacity { get; }

        public Money TotalEarnings { get; private set; }
    }
}
