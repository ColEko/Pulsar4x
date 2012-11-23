using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Pulsar4X.UI.Panels
{
    public partial class SysMap_Controls : DockContent
    {
        #region Properties

        /// <summary>   Gets the system selection combo box. </summary>
        public ComboBox SystemSelectionComboBox
        {
            get
            {
                return m_oSystemSelectionComboBox;
            }
        }

        /// <summary>   Gets the pan up button. </summary>
        public Button PanUpButton
        {
            get
            {
                return m_oPanUpButton;
            }
        }

        /// <summary>   Gets the pan down button. </summary>
        public Button PanDownButton
        {
            get
            {
                return m_oPanDownButton;
            }
        }

        /// <summary>   Gets the pan Left button. </summary>
        public Button PanLeftButton
        {
            get
            {
                return m_oPanLeftButton;
            }
        }

        /// <summary>   Gets the pan Right button. </summary>
        public Button PanRightButton
        {
            get
            {
                return m_oPanRightButton;
            }
        }

        /// <summary>   Gets the Zoom in button. </summary>
        public Button ZoomInButton
        {
            get
            {
                return m_oZoomInButton;
            }
        }

        /// <summary>   Gets the Zoom out button. </summary>
        public Button ZoomOutButton
        {
            get
            {
                return m_oZoomOutButton;
            }
        }

        /// <summary>   Gets the reset view button. </summary>
        public Button ResetViewButton
        {
            get
            {
                return m_oResetViewButton;
            }
        }

        #endregion

        public SysMap_Controls()
        {
            InitializeComponent();

            this.AutoHidePortion = 0.2f;
            this.HideOnClose = true;
            this.Text = "System Map";
            this.TabText = "System Map";
            this.ToolTipText = "System Map Controls";
        }
    }
}
