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
    public partial class FrmStartBooking : Form
    {
        internal Customer c;
        internal Car check;
        public FrmStartBooking(Customer c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new CustomerMenu(c);
            this.Hide();
            frm.Show();
        }

        private void FrmStartBooking_Load(object sender, EventArgs e)
        {
            CarDL.readCarFromFile();
            txtCustName.Text = c.Name;
            txtCustID.Text = c.IdCard;
            txtCustID.ReadOnly = true;
            txtCustName.ReadOnly = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            check = CarDL.fetchUnBook(cmbCategories.Text);
            if (check != null)
            {
                lblCarPlate.Visible = true;
                txtCarDetails.Visible = true;
                txtCarDetails.Text = check.LicensePlate;
                txtCarDetails.ReadOnly = true;
                btnBook.Visible = true;
                if (!CustomerDL.isCustomerAlreadyExist(c))
                {
                    c.IdCard = txtCustID.Text;
                    c.Address = txtCustAddress.Text;
                }
                else
                {
                    MessageBox.Show("Customer already exist, will use previous details.");
                    txtCustID.Text = c.IdCard;
                    txtCustAddress.Text = c.Address;
                    txtCustID.ReadOnly = true;
                    txtCustAddress.ReadOnly = true;
                }
            }
            else
                MessageBox.Show("Car not available in given categories. Please try again.");
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            
            Booking b = new Booking(check, c, DateTime.Today);
            b.BookCode = Booking.randomCodeGenerator();
            BookingDL.addIntoList(b);
            BookingDL.writeBookinginFile();
            MessageBox.Show("Booked Successfully.Your code for this booking is "+b.BookCode);
            this.Hide();
            Form frm = new CustomerMenu(c);
            frm.Show();
        }
    }
}
