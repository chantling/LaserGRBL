namespace LaserGRBL
{
    partial class GCodeOptionForm
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
            this.AutoHome = new System.Windows.Forms.GroupBox();
            this.lblZOffset = new System.Windows.Forms.Label();
            this.txtbxZOffset = new System.Windows.Forms.TextBox();
            this.cbAutoHome = new System.Windows.Forms.CheckBox();
            this.btnGCodeOptionOk = new System.Windows.Forms.Button();
            this.btnGCodeOptionCancel = new System.Windows.Forms.Button();
            this.AutoHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoHome
            // 
            this.AutoHome.Controls.Add(this.lblZOffset);
            this.AutoHome.Controls.Add(this.txtbxZOffset);
            this.AutoHome.Controls.Add(this.cbAutoHome);
            this.AutoHome.Location = new System.Drawing.Point(2, 2);
            this.AutoHome.Name = "AutoHome";
            this.AutoHome.Size = new System.Drawing.Size(280, 62);
            this.AutoHome.TabIndex = 0;
            this.AutoHome.TabStop = false;
            this.AutoHome.Text = "Autohome";
            // 
            // lblZOffset
            // 
            this.lblZOffset.AutoSize = true;
            this.lblZOffset.Enabled = false;
            this.lblZOffset.Location = new System.Drawing.Point(10, 38);
            this.lblZOffset.Name = "lblZOffset";
            this.lblZOffset.Size = new System.Drawing.Size(100, 13);
            this.lblZOffset.TabIndex = 2;
            this.lblZOffset.Text = "Laser Z-offset (mm):";
            // 
            // txtbxZOffset
            // 
            this.txtbxZOffset.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxZOffset.Enabled = false;
            this.txtbxZOffset.Location = new System.Drawing.Point(115, 35);
            this.txtbxZOffset.Name = "txtbxZOffset";
            this.txtbxZOffset.Size = new System.Drawing.Size(61, 20);
            this.txtbxZOffset.TabIndex = 1;
            // 
            // cbAutoHome
            // 
            this.cbAutoHome.AutoSize = true;
            this.cbAutoHome.Location = new System.Drawing.Point(6, 16);
            this.cbAutoHome.Name = "cbAutoHome";
            this.cbAutoHome.Size = new System.Drawing.Size(130, 17);
            this.cbAutoHome.TabIndex = 0;
            this.cbAutoHome.Text = "Home at start of print?";
            this.cbAutoHome.UseVisualStyleBackColor = true;
            this.cbAutoHome.CheckedChanged += new System.EventHandler(this.cbAutoHome_CheckedChanged);
            // 
            // btnGCodeOptionOk
            // 
            this.btnGCodeOptionOk.Location = new System.Drawing.Point(103, 227);
            this.btnGCodeOptionOk.Name = "btnGCodeOptionOk";
            this.btnGCodeOptionOk.Size = new System.Drawing.Size(75, 23);
            this.btnGCodeOptionOk.TabIndex = 1;
            this.btnGCodeOptionOk.Text = "Ok";
            this.btnGCodeOptionOk.UseVisualStyleBackColor = true;
            this.btnGCodeOptionOk.Click += new System.EventHandler(this.btnGCodeOptionOk_Click);
            // 
            // btnGCodeOptionCancel
            // 
            this.btnGCodeOptionCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGCodeOptionCancel.Location = new System.Drawing.Point(200, 227);
            this.btnGCodeOptionCancel.Name = "btnGCodeOptionCancel";
            this.btnGCodeOptionCancel.Size = new System.Drawing.Size(75, 23);
            this.btnGCodeOptionCancel.TabIndex = 2;
            this.btnGCodeOptionCancel.Text = "Cancel";
            this.btnGCodeOptionCancel.UseVisualStyleBackColor = true;
            this.btnGCodeOptionCancel.Click += new System.EventHandler(this.btnGCodeOptionCancel_Click);
            // 
            // GCodeOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnGCodeOptionCancel);
            this.Controls.Add(this.btnGCodeOptionOk);
            this.Controls.Add(this.AutoHome);
            this.Name = "GCodeOptionForm";
            this.Text = "GCode Options";
            this.TopMost = true;
            this.AutoHome.ResumeLayout(false);
            this.AutoHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AutoHome;
        private System.Windows.Forms.Label lblZOffset;
        private System.Windows.Forms.TextBox txtbxZOffset;
        private System.Windows.Forms.CheckBox cbAutoHome;
        private System.Windows.Forms.Button btnGCodeOptionOk;
        private System.Windows.Forms.Button btnGCodeOptionCancel;
    }
}