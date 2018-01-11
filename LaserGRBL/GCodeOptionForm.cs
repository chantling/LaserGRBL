using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaserGRBL
{
    public partial class GCodeOptionForm : Form
    {
        double ZOffsetValue;

        public GCodeOptionForm()
        {
            InitializeComponent();
            cbAutoHome.Checked = (bool)Settings.GetObject("AutoHome", false);
            txtbxZOffset.Text = Settings.GetObject("Z Offset", "0.0").ToString();

            
        }

        internal static void CreateAndShowDialog()
        {
            using (GCodeOptionForm sf = new GCodeOptionForm())
                sf.ShowDialog();
        }

        private void btnGCodeOptionOk_Click(object sender, EventArgs e)
        {
            // Ensure content of z offset textbox is numeric
            if (txtbxZOffsetValidate())
            {
                txtbxZOffset.BackColor = System.Drawing.SystemColors.Window;
                Settings.SetObject("AutoHome", cbAutoHome.Checked);
                Settings.SetObject("Z Offset", ZOffsetValue);
                if ((bool)Settings.GetObject("File currently open", true))
                    MessageBox.Show("A file is currently loaded.  Reload the file for the changes to take effect.");
                Close();
            }
            else
            { }
        }

        private void btnGCodeOptionCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbAutoHome_CheckedChanged(object sender, EventArgs e)
        {
                txtbxZOffset.Enabled = cbAutoHome.Checked;
                lblZOffset.Enabled = cbAutoHome.Checked;

        }

        private bool txtbxZOffsetValidate()
        {
            bool validText = double.TryParse(txtbxZOffset.Text, out ZOffsetValue);

            if (!validText)
            {
                MessageBox.Show("Z Offset must be a number", "Error");
                txtbxZOffset.Text = "0";
                txtbxZOffset.BackColor = Color.Red;
                return false;
            }
            return true;
        }

    }
}
