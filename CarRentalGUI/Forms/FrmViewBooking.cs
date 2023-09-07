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
    public partial class FrmViewBooking : Form
    {
        public FrmViewBooking()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new AdminMenu();
            frm.Show();
            this.Hide();
        }
        public void dataBind()
        {
            bookingsGV.DataSource = null;
            foreach(Booking b in BookingDL.Books)
            {
                string licensePlate = b.IsCurrentlyBook.LicensePlate;
                bookingsGV.DataSource = BookingDL.Books.Select(c => new { licensePlate, c.BookCode }).ToList();
            }
           
        }

        private void FrmViewBooking_Load(object sender, EventArgs e)
        {
            BookingDL.readBookingFromFile();
            dataBind();
        }
    }
}
