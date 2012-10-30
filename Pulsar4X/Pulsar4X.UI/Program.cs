using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

            // Init our UI Controller:
            Helpers.UIController.Instance.Initialise();

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainForm());
        }
    }
}
