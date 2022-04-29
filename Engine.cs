using System;
using System.Collections.Generic;
using System.Text;
using GiantKillers.Utils;

namespace GiantKillers
{
    public sealed class Engine
    {
        private static readonly Lazy<Engine> lazy = new Lazy<Engine>(() => new Engine());

        public static Engine Instance { get { return lazy.Value; } }

        private Engine()
        {
            Initialise();
        }

        private void Initialise()
        {
            // Initialise the configuration
            ConfigManager.Instance.Initialise();
        }
    }
}
