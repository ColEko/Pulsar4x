using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Pulsar4X.UI.Forms
{
    public partial class MainForm : Form
    {
        DockPanel m_oDockPanel;

        public MainForm()
        {
            InitializeComponent();

            // Create and Add docking Panel:
            m_oDockPanel = new DockPanel();
            m_oDockPanel.DocumentStyle = DocumentStyle.DockingWindow;
            m_oDockPanel.Dock = DockStyle.Fill;

            // set Mono only stuff:
            if (Helpers.UIController.Instance.IsRunningOnMono)
            {
                m_oDockPanel.SupportDeeplyNestedContent = false;
                m_oDockPanel.AllowEndUserDocking = false;
                m_oDockPanel.AllowEndUserNestedDocking = false;
            }

            m_oToolStripContainer.ContentPanel.Controls.Add(m_oDockPanel);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Setup Events:
            exitToolStripMenuItem.Click += new EventHandler(exitToolStripMenuItem_Click);
            systemInformationToolStripMenuItem.Click += new EventHandler(systemInformationToolStripMenuItem_Click);
        }

        #region MenuAndToolStripEvents

        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void systemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.UIController.Instance.SystemGenAndDisplay.ShowAllPanels(m_oDockPanel);
        }


        #endregion
    }
}
