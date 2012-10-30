using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace Pulsar4X.UI.Handlers
{
    public class SystemGenAndDisplay
    {
        /// <summary>
        /// Panel that contains the Star and Planet Data grids.
        /// </summary>
        Panels.SGaD_DataPanel m_oDataPanel;




        public SystemGenAndDisplay()
        {
            m_oDataPanel = new Panels.SGaD_DataPanel();
        }


        #region PublicMethods

        public void ShowAllPanels(DockPanel a_oDockPanel)
        {
            m_oDataPanel.Show(a_oDockPanel, DockState.Document);
        }

        public void ShowDataPanel(DockPanel a_oDockPanel)
        {
            m_oDataPanel.Show(a_oDockPanel, DockState.Document);
        }

        #endregion
        
    }
}
