using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Pulsar4X.Stargen;

namespace Pulsar4X.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // gen star system:
            var ssf = new StarSystemFactory(true);
            GameState.Instance.StarSystems.Add(ssf.Create("Test"));
            GameState.Instance.StarSystems.Add(ssf.Create("Foo"));
            GameState.Instance.StarSystems.Add(ssf.Create("Bar"));

            // Init our UI Controller:
            Helpers.UIController.Instance.Initialise();

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainForm());
        }
    }
}
