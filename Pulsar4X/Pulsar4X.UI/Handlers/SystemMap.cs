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

            // Bind System Selection Combo Box.
            m_oControlsPanel.SystemSelectionComboBox.Bind(c => c.DataSource, VM, d => d.StarSystems);
            m_oControlsPanel.SystemSelectionComboBox.Bind(c => c.SelectedItem, VM, d => d.CurrentStarSystem, DataSourceUpdateMode.OnPropertyChanged);
            m_oControlsPanel.SystemSelectionComboBox.DisplayMember = "Name";
            VM.StarSystemChanged += (s, args) => m_oCurrnetSystem = VM.CurrentStarSystem;
            m_oCurrnetSystem = VM.CurrentStarSystem;
            m_oControlsPanel.SystemSelectionComboBox.SelectedIndexChanged += (s, args) => m_oControlsPanel.SystemSelectionComboBox.DataBindings["SelectedItem"].WriteValue();
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
