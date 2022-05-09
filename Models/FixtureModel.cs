using System;
using System.Collections.Generic;
using System.Text;

namespace GiantKillers.Models
{
    class FixtureModel
    {
        Tuple<TeamModel, TeamModel> Teams { get; }

        Tuple<int, int> Score { get; }

        public FixtureModel(TeamModel homeTeam, TeamModel awayTeam)
        {
            Teams = new Tuple<TeamModel, TeamModel>(homeTeam, awayTeam);
        }
    }
}
