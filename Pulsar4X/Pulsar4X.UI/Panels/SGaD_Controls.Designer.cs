﻿namespace Pulsar4X.UI.Panels
{
    partial class SGaD_Controls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_oSystemSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.m_oSystemInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_oSystemTypeTextBox = new System.Windows.Forms.TextBox();
            this.m_oAgeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_oDisscoveredDateTextBox = new System.Windows.Forms.TextBox();
            this.m_oControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oSMControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.m_oGenSystemButton = new System.Windows.Forms.Button();
            this.m_oGenGalaxyButton = new System.Windows.Forms.Button();
            this.m_oAutoRenameButton = new System.Windows.Forms.Button();
            this.m_oAddColonyButton = new System.Windows.Forms.Button();
            this.m_oExportButton = new System.Windows.Forms.Button();
            this.m_oDeleteSystemButton = new System.Windows.Forms.Button();
            this.m_oSystemInfoGroupBox.SuspendLayout();
            this.m_oControlsGroupBox.SuspendLayout();
            this.m_oSMControlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_oSystemSelectionComboBox
            // 
            this.m_oSystemSelectionComboBox.FormattingEnabled = true;
            this.m_oSystemSelectionComboBox.Location = new System.Drawing.Point(13, 13);
            this.m_oSystemSelectionComboBox.Name = "m_oSystemSelectionComboBox";
            this.m_oSystemSelectionComboBox.Size = new System.Drawing.Size(183, 21);
            this.m_oSystemSelectionComboBox.TabIndex = 0;
            // 
            // m_oSystemInfoGroupBox
            // 
            this.m_oSystemInfoGroupBox.Controls.Add(this.m_oDisscoveredDateTextBox);
            this.m_oSystemInfoGroupBox.Controls.Add(this.label3);
            this.m_oSystemInfoGroupBox.Controls.Add(this.label2);
            this.m_oSystemInfoGroupBox.Controls.Add(this.m_oAgeTextBox);
            this.m_oSystemInfoGroupBox.Controls.Add(this.m_oSystemTypeTextBox);
            this.m_oSystemInfoGroupBox.Controls.Add(this.label1);
            this.m_oSystemInfoGroupBox.Location = new System.Drawing.Point(13, 41);
            this.m_oSystemInfoGroupBox.Name = "m_oSystemInfoGroupBox";
            this.m_oSystemInfoGroupBox.Size = new System.Drawing.Size(183, 108);
            this.m_oSystemInfoGroupBox.TabIndex = 1;
            this.m_oSystemInfoGroupBox.TabStop = false;
            this.m_oSystemInfoGroupBox.Text = "System Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // m_oSystemTypeTextBox
            // 
            this.m_oSystemTypeTextBox.Location = new System.Drawing.Point(43, 20);
            this.m_oSystemTypeTextBox.Name = "m_oSystemTypeTextBox";
            this.m_oSystemTypeTextBox.Size = new System.Drawing.Size(134, 20);
            this.m_oSystemTypeTextBox.TabIndex = 1;
            // 
            // m_oAgeTextBox
            // 
            this.m_oAgeTextBox.Location = new System.Drawing.Point(43, 47);
            this.m_oAgeTextBox.Name = "m_oAgeTextBox";
            this.m_oAgeTextBox.Size = new System.Drawing.Size(134, 20);
            this.m_oAgeTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discovered:";
            // 
            // m_oDisscoveredDateTextBox
            // 
            this.m_oDisscoveredDateTextBox.Location = new System.Drawing.Point(76, 75);
            this.m_oDisscoveredDateTextBox.Name = "m_oDisscoveredDateTextBox";
            this.m_oDisscoveredDateTextBox.Size = new System.Drawing.Size(101, 20);
            this.m_oDisscoveredDateTextBox.TabIndex = 5;
            // 
            // m_oControlsGroupBox
            // 
            this.m_oControlsGroupBox.Controls.Add(this.m_oExportButton);
            this.m_oControlsGroupBox.Controls.Add(this.m_oAddColonyButton);
            this.m_oControlsGroupBox.Controls.Add(this.m_oAutoRenameButton);
            this.m_oControlsGroupBox.Location = new System.Drawing.Point(13, 156);
            this.m_oControlsGroupBox.Name = "m_oControlsGroupBox";
            this.m_oControlsGroupBox.Size = new System.Drawing.Size(183, 84);
            this.m_oControlsGroupBox.TabIndex = 2;
            this.m_oControlsGroupBox.TabStop = false;
            this.m_oControlsGroupBox.Text = "Controls:";
            // 
            // m_oSMControlsGroupBox
            // 
            this.m_oSMControlsGroupBox.Controls.Add(this.m_oDeleteSystemButton);
            this.m_oSMControlsGroupBox.Controls.Add(this.m_oGenGalaxyButton);
            this.m_oSMControlsGroupBox.Controls.Add(this.m_oGenSystemButton);
            this.m_oSMControlsGroupBox.Location = new System.Drawing.Point(13, 246);
            this.m_oSMControlsGroupBox.Name = "m_oSMControlsGroupBox";
            this.m_oSMControlsGroupBox.Size = new System.Drawing.Size(183, 82);
            this.m_oSMControlsGroupBox.TabIndex = 3;
            this.m_oSMControlsGroupBox.TabStop = false;
            this.m_oSMControlsGroupBox.Text = "SM Controls:";
            // 
            // m_oGenSystemButton
            // 
            this.m_oGenSystemButton.Location = new System.Drawing.Point(11, 20);
            this.m_oGenSystemButton.Name = "m_oGenSystemButton";
            this.m_oGenSystemButton.Size = new System.Drawing.Size(75, 23);
            this.m_oGenSystemButton.TabIndex = 0;
            this.m_oGenSystemButton.Text = "Gen System";
            this.m_oGenSystemButton.UseVisualStyleBackColor = true;
            // 
            // m_oGenGalaxyButton
            // 
            this.m_oGenGalaxyButton.Location = new System.Drawing.Point(93, 19);
            this.m_oGenGalaxyButton.Name = "m_oGenGalaxyButton";
            this.m_oGenGalaxyButton.Size = new System.Drawing.Size(75, 23);
            this.m_oGenGalaxyButton.TabIndex = 1;
            this.m_oGenGalaxyButton.Text = "Gen Galaxy";
            this.m_oGenGalaxyButton.UseVisualStyleBackColor = true;
            // 
            // m_oAutoRenameButton
            // 
            this.m_oAutoRenameButton.Location = new System.Drawing.Point(11, 20);
            this.m_oAutoRenameButton.Name = "m_oAutoRenameButton";
            this.m_oAutoRenameButton.Size = new System.Drawing.Size(75, 23);
            this.m_oAutoRenameButton.TabIndex = 0;
            this.m_oAutoRenameButton.Text = "Auto Rename";
            this.m_oAutoRenameButton.UseVisualStyleBackColor = true;
            // 
            // m_oAddColonyButton
            // 
            this.m_oAddColonyButton.Location = new System.Drawing.Point(93, 20);
            this.m_oAddColonyButton.Name = "m_oAddColonyButton";
            this.m_oAddColonyButton.Size = new System.Drawing.Size(75, 23);
            this.m_oAddColonyButton.TabIndex = 1;
            this.m_oAddColonyButton.Text = "Add Colony";
            this.m_oAddColonyButton.UseVisualStyleBackColor = true;
            // 
            // m_oExportButton
            // 
            this.m_oExportButton.Location = new System.Drawing.Point(11, 50);
            this.m_oExportButton.Name = "m_oExportButton";
            this.m_oExportButton.Size = new System.Drawing.Size(75, 23);
            this.m_oExportButton.TabIndex = 2;
            this.m_oExportButton.Text = "Export";
            this.m_oExportButton.UseVisualStyleBackColor = true;
            // 
            // m_oDeleteSystemButton
            // 
            this.m_oDeleteSystemButton.Location = new System.Drawing.Point(11, 50);
            this.m_oDeleteSystemButton.Name = "m_oDeleteSystemButton";
            this.m_oDeleteSystemButton.Size = new System.Drawing.Size(75, 23);
            this.m_oDeleteSystemButton.TabIndex = 2;
            this.m_oDeleteSystemButton.Text = "Del System";
            this.m_oDeleteSystemButton.UseVisualStyleBackColor = true;
            // 
            // SGaD_Controls
            // 
            this.AutoHidePortion = 0.2D;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 334);
            this.Controls.Add(this.m_oSMControlsGroupBox);
            this.Controls.Add(this.m_oControlsGroupBox);
            this.Controls.Add(this.m_oSystemInfoGroupBox);
            this.Controls.Add(this.m_oSystemSelectionComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "SGaD_Controls";
            this.TabText = "System Information";
            this.Text = "System Information Controls";
            this.ToolTipText = "System Information Controls";
            this.m_oSystemInfoGroupBox.ResumeLayout(false);
            this.m_oSystemInfoGroupBox.PerformLayout();
            this.m_oControlsGroupBox.ResumeLayout(false);
            this.m_oSMControlsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox m_oSystemSelectionComboBox;
        private System.Windows.Forms.GroupBox m_oSystemInfoGroupBox;
        private System.Windows.Forms.TextBox m_oDisscoveredDateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_oAgeTextBox;
        private System.Windows.Forms.TextBox m_oSystemTypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox m_oControlsGroupBox;
        private System.Windows.Forms.Button m_oExportButton;
        private System.Windows.Forms.Button m_oAddColonyButton;
        private System.Windows.Forms.Button m_oAutoRenameButton;
        private System.Windows.Forms.GroupBox m_oSMControlsGroupBox;
        private System.Windows.Forms.Button m_oDeleteSystemButton;
        private System.Windows.Forms.Button m_oGenGalaxyButton;
        private System.Windows.Forms.Button m_oGenSystemButton;
    }
}
