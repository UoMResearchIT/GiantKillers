using System;
using GiantKillers.Enums;
using NodaMoney;

namespace GiantKillers.Models
{
    public class TeamModel
    {
        // FIXED CONFIG //

        public League League { get; }

        public string Name { get; }

        public Category Category { get; }

        public Money GateValue { get; }

        public int GroundCapacity { get; }

        // STATUS //

        public Money TotalEarnings { get; private set; }

        // TODO: There will be more status related things here when we work out what we need

        public TeamModel(
            League league,
            string name,
            Category category,
            Money gateValue,
            int groundCapacity
        )
        {
            Name = name;
            Category = category;
            GateValue = gateValue;
            GroundCapacity = groundCapacity;
        }
    }
}
