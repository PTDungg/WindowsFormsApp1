using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }

        private void btnClick_Show(object sender, EventArgs e)
        {
            int age =DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
            string s = "My name is: " + txtYourName.Text + "\n" + age.ToString();
            MessageBox.Show(s);
        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtYourName, "Your must enter Your Name");
            else
                this.errorProvider1.Clear();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(txtYear, "This is not invalid number");
            else
                this.errorProvider1.Clear();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
