using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Pulsar4X.UI.ViewModels;
using Pulsar4X.Entities;
using Pulsar4X.Stargen;

namespace Pulsar4X.UI.Handlers
{
    public class SystemGenAndDisplay
    {
        /// <summary>
        /// Panel that contains the Star and Planet Data grids.
        /// </summary>
        Panels.SGaD_DataPanel m_oDataPanel;

        public StarSystemViewModel VM { get; set; }

        // Some Temp Vars until we work out a better way to do Gen Systems from here.
        StarSystemFactory ssf = new StarSystemFactory(true);
        int m_iNumberOfNewSystemsGened = 0;

        public SystemGenAndDisplay()
        {
            // Create Panels:
            m_oDataPanel = new Panels.SGaD_DataPanel();

            // setup view model:
            VM = new StarSystemViewModel();

            VM.CurrentStarSystem = GameState.Instance.StarSystems.FirstOrDefault();

            // Setup the stars Grid
            m_oDataPanel.StarDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            m_oDataPanel.StarDataGrid.RowHeadersVisible = false;
            m_oDataPanel.StarDataGrid.AutoGenerateColumns = false;
            m_oDataPanel.StarDataGrid.Bind(c => c.AllowUserToAddRows, VM, d => d.isSM);
            m_oDataPanel.StarDataGrid.Bind(c => c.AllowUserToDeleteRows, VM, d => d.isSM);
            m_oDataPanel.StarDataGrid.Bind(c => c.ReadOnly, VM, d => d.isNotSM);

            AddColumnsToStarDataGrid();

            m_oDataPanel.StarDataGrid.DataSource = VM.StarsSource;
            m_oDataPanel.StarDataGrid.SelectionChanged += new EventHandler(StarsDataGrid_SelectionChanged);

            // Setup the Planet Data Grid
            m_oDataPanel.PlanetsDataGrid.AutoGenerateColumns = false;
            m_oDataPanel.PlanetsDataGrid.RowHeadersVisible = false;
            m_oDataPanel.PlanetsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            m_oDataPanel.PlanetsDataGrid.Bind(c => c.AllowUserToAddRows, VM, d => d.isSM);
            m_oDataPanel.PlanetsDataGrid.Bind(c => c.AllowUserToDeleteRows, VM, d => d.isSM);
            m_oDataPanel.PlanetsDataGrid.Bind(c => c.ReadOnly, VM, d => d.isNotSM);
            AddColumnsToPlanetDataGrid();

            m_oDataPanel.PlanetsDataGrid.DataSource = VM.PlanetSource;
            m_oDataPanel.PlanetsDataGrid.SelectionChanged += new EventHandler(PlanetsDataGrid_SelectionChanged);
        }

        #region EventHandlers

        void StarsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            var sel = m_oDataPanel.StarDataGrid.SelectedRows;
            if (sel.Count > 0)
            {
                VM.CurrentStar = (Star)sel[0].DataBoundItem;
                m_oDataPanel.PlanetsDataGrid.DataSource = VM.PlanetSource;
            }
        }

        void PlanetsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            var sel = m_oDataPanel.PlanetsDataGrid.SelectedRows;
            if (sel.Count > 0)
            {
                VM.CurrentPlanet = (Planet)sel[0].DataBoundItem;
            }
        }

        #endregion

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

        #region PrivateMethods

        private void AddColumnsToStarDataGrid()
        {
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "Name";
                col.HeaderText = "Name";
                m_oDataPanel.StarDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "Class";
                col.HeaderText = "Class";
                m_oDataPanel.StarDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "Radius";
                col.HeaderText = "Radius";
                col.DefaultCellStyle.Format = "N4";
                m_oDataPanel.StarDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "Mass";
                col.HeaderText = "Mass";
                col.DefaultCellStyle.Format = "N4";
                m_oDataPanel.StarDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "Luminosity";
                col.HeaderText = "Luminosity";
                col.DefaultCellStyle.Format = "N4";
                m_oDataPanel.StarDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "Temperature";
                col.HeaderText = "Temperature";
                col.DefaultCellStyle.Format = "N4";
                m_oDataPanel.StarDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "EcoSphereRadius";
                col.HeaderText = "Habitable Zone";
                col.DefaultCellStyle.Format = "N4";
                m_oDataPanel.StarDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "SemiMajorAxis";
                col.HeaderText = "Orbital Radius (AU)";
                col.DefaultCellStyle.Format = "N4";
                m_oDataPanel.StarDataGrid.Columns.Add(col);
            }
        }

        private void AddColumnsToPlanetDataGrid()
        {
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "Name";
                col.HeaderText = "Name";
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "PlanetTypeView";
                col.HeaderText = "Type";
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "SurfaceTemperatureView";
                col.HeaderText = "Surface Temperature (K)";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "SurfaceGravityView";
                col.HeaderText = "Surface Gravity";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "MassOfGasInEarthMassesView";
                col.HeaderText = "Atmosphere (Earth Masses)";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "SemiMajorAxis";
                col.HeaderText = "Orbit Dist (AU)";
                col.DefaultCellStyle.Format = "N4";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "SurfacePressureView";
                col.HeaderText = "Surface Pressure (mb)";
                col.DefaultCellStyle.Format = "N4";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "Radius";
                col.HeaderText = "Equitorial Radius (Km)";
                col.DefaultCellStyle.Format = "N1";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "HydrosphereCoverInPercent";
                col.HeaderText = "Hydrosphere Cover - Liquid (%)";
                col.DefaultCellStyle.Format = "N1";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "IceCoverInPercent";
                col.HeaderText = "Hydrosphere Cover - Solid (%)";
                col.DefaultCellStyle.Format = "N1";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "CloudCoverInPercent";
                col.HeaderText = "Cloud Cover (%)";
                col.DefaultCellStyle.Format = "N1";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "OrbitalPeriod";
                col.HeaderText = "Year (Earth Days)";
                col.DefaultCellStyle.Format = "N2";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "AxialTilt";
                col.HeaderText = "Axial Tilt";
                col.DefaultCellStyle.Format = "N0";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "MassInEarthMassesView";
                col.HeaderText = "Mass (Earth Masses)";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "Density";
                col.HeaderText = "Density (g/cc)";
                col.DefaultCellStyle.Format = "N4";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "EscapeVelocity";
                col.HeaderText = "Escape Velocity (cm/s)";
                col.DefaultCellStyle.Format = "N2";
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "IsInResonantRotation";
                col.HeaderText = "Tidal Lock";
                //col.DefaultCellStyle.Format .Format = "N4";
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
            using (DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn())
            {
                col.DataPropertyName = "Albedo";
                col.HeaderText = "Albedo";
                col.DefaultCellStyle.Format = "N4";
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                m_oDataPanel.PlanetsDataGrid.Columns.Add(col);
            }
        }


        #endregion

    }
}
