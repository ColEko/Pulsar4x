﻿namespace Pulsar4X
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceMasterOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceMasterOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empiresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscellaneousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commanderNameThemesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.spaceMasterToolStripMenuItem,
            this.empiresToolStripMenuItem,
            this.calculationsToolStripMenuItem,
            this.gameParametersToolStripMenuItem,
            this.miscellaneousToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(537, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.TabStop = true;
            this.MainMenu.Text = "MainMenu";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // spaceMasterToolStripMenuItem
            // 
            this.spaceMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spaceMasterOnToolStripMenuItem,
            this.spaceMasterOffToolStripMenuItem});
            this.spaceMasterToolStripMenuItem.Name = "spaceMasterToolStripMenuItem";
            this.spaceMasterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.spaceMasterToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.spaceMasterToolStripMenuItem.Text = "&Space Master";
            // 
            // spaceMasterOnToolStripMenuItem
            // 
            this.spaceMasterOnToolStripMenuItem.Name = "spaceMasterOnToolStripMenuItem";
            this.spaceMasterOnToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.spaceMasterOnToolStripMenuItem.Text = "SpaceMaster On";
            // 
            // spaceMasterOffToolStripMenuItem
            // 
            this.spaceMasterOffToolStripMenuItem.Name = "spaceMasterOffToolStripMenuItem";
            this.spaceMasterOffToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.spaceMasterOffToolStripMenuItem.Text = "SpaceMaster Off";
            // 
            // empiresToolStripMenuItem
            // 
            this.empiresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemMapToolStripMenuItem,
            this.systemInformationToolStripMenuItem});
            this.empiresToolStripMenuItem.Name = "empiresToolStripMenuItem";
            this.empiresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.empiresToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.empiresToolStripMenuItem.Text = "&Empire";
            // 
            // systemInformationToolStripMenuItem
            // 
            this.systemInformationToolStripMenuItem.Image = global::Pulsar4X.Properties.Resources.application_view_columns;
            this.systemInformationToolStripMenuItem.Name = "systemInformationToolStripMenuItem";
            this.systemInformationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.systemInformationToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.systemInformationToolStripMenuItem.Text = "System Information";
            this.systemInformationToolStripMenuItem.Click += new System.EventHandler(this.systemInformationToolStripMenuItem_Click);
            // 
            // calculationsToolStripMenuItem
            // 
            this.calculationsToolStripMenuItem.Name = "calculationsToolStripMenuItem";
            this.calculationsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.calculationsToolStripMenuItem.Text = "Calculations";
            // 
            // gameParametersToolStripMenuItem
            // 
            this.gameParametersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.gameParametersToolStripMenuItem.Name = "gameParametersToolStripMenuItem";
            this.gameParametersToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.gameParametersToolStripMenuItem.Text = "Game Parameters";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // miscellaneousToolStripMenuItem
            // 
            this.miscellaneousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commanderNameThemesToolStripMenuItem});
            this.miscellaneousToolStripMenuItem.Name = "miscellaneousToolStripMenuItem";
            this.miscellaneousToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.miscellaneousToolStripMenuItem.Text = "Miscellaneous";
            // 
            // commanderNameThemesToolStripMenuItem
            // 
            this.commanderNameThemesToolStripMenuItem.Name = "commanderNameThemesToolStripMenuItem";
            this.commanderNameThemesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.commanderNameThemesToolStripMenuItem.Text = "Commander Name Themes";
            this.commanderNameThemesToolStripMenuItem.Click += new System.EventHandler(this.commanderNameThemesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1008, 706);
            this.MainPanel.TabIndex = 2;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Pulsar4X.Properties.Resources.door_out;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // systemMapToolStripMenuItem
            // 
            this.systemMapToolStripMenuItem.Image = global::Pulsar4X.Properties.Resources.application_view_gallery;
            this.systemMapToolStripMenuItem.Name = "systemMapToolStripMenuItem";
            this.systemMapToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.systemMapToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.systemMapToolStripMenuItem.Text = "System Map";
            this.systemMapToolStripMenuItem.Click += new System.EventHandler(this.systemMapToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1008, 706);
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Pulsar4X";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spaceMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empiresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscellaneousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spaceMasterOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spaceMasterOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemInformationToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem systemMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commanderNameThemesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

