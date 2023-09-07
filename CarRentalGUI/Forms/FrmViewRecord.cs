using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalGUI.BL;
using CarRentalGUI.DL;
using CarRentalGUI.Forms;

namespace CarRentalGUI.Forms
{
    public partial class FrmViewRecord : Form
    {
        internal Customer c;
        public FrmViewRecord(Customer c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void FrmViewRecord_Load(object sender, EventArgs e)
        {
            if(!CustomerDL.isCustomerHaveDetails(c))
            {
                MessageBox.Show("You do not have further details, please update them through update section.");
                Form frm = new CustomerMenu(c);
                this.Hide();
                frm.Show();
            }
            else
            {
                txtCustName.Text = c.Name;
                txtCustID.Text = c.IdCard;
                txtCustAddress.Text = c.Address;
                txtCustAddress.ReadOnly = true;
                txtCustID.ReadOnly = true;
                txtCustName.ReadOnly = true;
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new CustomerMenu(c);
            this.Hide();
            frm.Show();
        }
    }
}
