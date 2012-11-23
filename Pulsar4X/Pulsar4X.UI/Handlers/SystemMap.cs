using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Pulsar4X.UI.ViewModels;
using Pulsar4X.Entities;
using Pulsar4X.Stargen;
using log4net.Config;
using log4net;

namespace Pulsar4X.UI.Handlers
{
    public class SystemMap
    {
        /// <summary>
        /// Panel that contains the System map view port (i.e. openGL canvas).
        /// </summary>
        Panels.SysMap_ViewPort m_oViewPortPanel;

        /// <summary>
        /// Panel that contains the System Map Controls.
        /// </summary>
        Panels.SysMap_Controls m_oControlsPanel;

        // System Map Logger:
        public static readonly ILog logger = LogManager.GetLogger(typeof(SystemMap));

        /// <summary> The currnet star system </summary>
        private Pulsar4X.Entities.StarSystem m_oCurrnetSystem;

        public GLStarSystemViewModel VM { get; set; }

        public SystemMap()
        {
            m_oViewPortPanel = new Panels.SysMap_ViewPort();
            m_oControlsPanel = new Panels.SysMap_Controls();

            VM = new GLStarSystemViewModel();
        }

        #region PublicMethods

        public void ShowAllPanels(DockPanel a_oDockPanel)
        {
            ShowViewPortPanel(a_oDockPanel);
            ShowControlsPanel(a_oDockPanel);
        }

        public void ShowViewPortPanel(DockPanel a_oDockPanel)
        {
            m_oViewPortPanel.Show(a_oDockPanel, DockState.Document);
        }

        public void ShowControlsPanel(DockPanel a_oDockPanel)
        {
            m_oControlsPanel.Show(a_oDockPanel, DockState.DockLeft);
        }

        #endregion
    }
}
