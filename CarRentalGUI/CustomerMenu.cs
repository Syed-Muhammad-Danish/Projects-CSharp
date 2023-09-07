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

namespace CarRentalGUI
{
    public partial class CustomerMenu : Form
    {
        internal Customer c;
        public CustomerMenu(Customer c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void bookCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmStartBooking(c);
            this.Hide();
            frm.Show();
            
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {   
            CustomerDL.readCustomerfromFile();
            bool check = CustomerDL.isCustomerHaveDetails(c);

            if(!check)
            {
                Form frm = new FrmUpdateRecord(c);
                frm.Show();
                this.Close();
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormMain();
            this.Hide();
            frm.Show();
        }

        private void viewPerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmViewRecord(c);
            this.Hide();
            frm.Show();
        }

        private void updatePersonalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmUpdateRecord(c);
            this.Hide();
            frm.Show();
        }
    }
}
