using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalGUI.Forms;
using CarRentalGUI.BL;
using CarRentalGUI.DL;


namespace CarRentalGUI.Forms
{
    public partial class FrmAddMaintenance : Form
    {
        internal Car check;
        public FrmAddMaintenance()
        {
            InitializeComponent();
        }

        private void txtLP_TextChanged(object sender, EventArgs e)
        {
            check = CarDL.getAcar(txtLP.Text);
            if (check != null)
            {
                txtLP.ReadOnly = true;
                lblOC.Visible = true;
                lblComments.Visible = true;

                txtOilChange.Visible = true;
                txtComments.Visible = true;
            }
            
        }

        private void FrmAddMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new AdminMenu();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                check.Maint.OilChange = Convert.ToDouble(txtOilChange.Text);
                check.Maint.Comments = txtComments.Text;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void FrmAddMaintenance_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
