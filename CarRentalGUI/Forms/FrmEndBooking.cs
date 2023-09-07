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
    public partial class FrmEndBooking : Form
    {
        internal Booking b;
        internal double price;
        internal double fPrice; 
        public FrmEndBooking()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBookCode_TextChanged(object sender, EventArgs e)
        {
            string code = txtBookCode.Text;
            b = BookingDL.getDetails(code);
            if(b != null)
            {
                txtPrice.Visible = true;
                txtBill.Visible = true;
                txtBill.ReadOnly = false;
                lblBill.Visible = true;
                label4.Visible = true;
                btnEndBooking.Visible = true;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                price = Convert.ToDouble(txtPrice.Text);
                fPrice = b.endBooking(price);
                txtBill.Text = Convert.ToString(fPrice);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnEndBooking_Click(object sender, EventArgs e)
        {

            BookingDL.removeBooking(b);
            b.IsCurrentlyBook.isBooked = false;
            BookingDL.writeBookinginFile();
            MessageBox.Show("Booking removed successfully.");
            Form frm = new AdminMenu();
            frm.Show();
            this.Hide();
        }

        private void FrmEndBooking_Load(object sender, EventArgs e)
        {
            BookingDL.readBookingFromFile();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new AdminMenu();
            this.Hide();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
