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

namespace CarRentalGUI
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new AddCar();
            frm.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new FormMain();
            frm.Show();
        }

        private void viewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new ViewCar();
            frm.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new FrmAddUser();
            frm.Show();
        }

        private void addMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new FrmAddMaintenance();
            frm.Show();
        }

        private void viewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new FrmViewBooking();
            frm.Show();
        }

        private void endBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmEndBooking();
            this.Hide();
            frm.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
