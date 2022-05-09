using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GiantKillers.Enums;
using GiantKillers.Models;
using GiantKillers.Utils;

namespace GiantKillers
{
    public sealed class Engine
    {
        private static readonly Lazy<Engine> lazy = new Lazy<Engine>(() => new Engine());

        public static Engine Instance { get { return lazy.Value; } }

        private TournamentRound currentRound;
        IList<FixtureModel> currentFixtures = new List<FixtureModel>();

        private Engine()
        {
            Initialise();
        }

        public void Draw()
        {
            List<TeamModel> availableTeams = new List<TeamModel>();
            if (currentRound == TournamentRound.First)
            {
                availableTeams = ConfigManager.Instance.GetTeams().Where(x => (int)x.League > 1).ToList();
            }
            else
            {
                // TODO:
            }

            // TODO: Now draw the fixtures

        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        private void Initialise()
        {
            // Initialise the configuration
            ConfigManager.Instance.Initialise();
        }

        // TODO: Expose various methods here to allow an app to control the game
    }
}
