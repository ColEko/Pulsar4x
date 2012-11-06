namespace Pulsar4X.UI.Panels
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
            // SGaD_Controls
            // 
            this.AutoHidePortion = 0.2D;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 576);
            this.Controls.Add(this.m_oSystemSelectionComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "SGaD_Controls";
            this.TabText = "System Information";
            this.Text = "System Information Controls";
            this.ToolTipText = "System Information Controls";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox m_oSystemSelectionComboBox;
    }
}
