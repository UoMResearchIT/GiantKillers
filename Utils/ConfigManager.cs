using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using GiantKillers.Enums;
using GiantKillers.Models;
using NodaMoney;

namespace GiantKillers.Utils
{
    public sealed class ConfigManager
    {
        private static readonly Lazy<ConfigManager> lazy = new Lazy<ConfigManager>(() => new ConfigManager());

        public static ConfigManager Instance { get { return lazy.Value; } }

        private ConfigManager()
        {
        }

        private IReadOnlyList<TeamModel> knownTeams;

        public void Initialise()
        {
            // Read the data about the teams from the config file
            var teams = new List<TeamModel>();
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("GiantKillers.Config.TeamConfig.csv"))
            {
                if (stream == null)
                {
                    throw new IOException("TeamConfig stream is null!");
                }

                using (var sr = new StreamReader(stream))
                {
                    var line = sr.ReadLine();
                    while (line != null)
                    {
                        var teamData = line.Split(',');
                        if (teamData.Length != 5) continue;
                        if (!int.TryParse(teamData[0], out int league)) continue;
                        if (!int.TryParse(teamData[2], out int category)) continue;
                        if (!int.TryParse(teamData[3], out int gate)) continue;
                        if (!int.TryParse(teamData[4], out int cap)) continue;

                        // Add team to known list
                        teams.Add(new TeamModel((League)league, teamData[1], (Category)category, new Money(gate), cap));
                    }
                }

                knownTeams = teams.AsReadOnly();
            };

        }
    }
}
