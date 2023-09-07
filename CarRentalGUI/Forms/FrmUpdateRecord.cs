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
    public partial class FrmUpdateRecord : Form
    {
        internal Customer c;
        private bool isUpdated = true;
        public FrmUpdateRecord(Customer c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!isUpdated)
            {
                Form frm = new CustomerMenu(c);
                this.Hide();
                frm.Show();
            }
        }

        private void FrmUpdateRecord_Load(object sender, EventArgs e)
        {
            try
            {
                CustomerDL.readCustomerfromFile();
                Customer check = CustomerDL.fetchCustomer(c);
                c = check;
                txtCustName.Text = c.Name;
                txtCustName.ReadOnly = true;
                txtCustID.Text = c.IdCard;
            }
            catch(Exception exp)
            {
                MessageBox.Show(c.Name);
            }
            //txtCustID.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                isUpdated = false;
                c.IdCard = txtCustID.Text;
                if (!isNumberIDCardCorrect(c.IdCard) || !isCorrectIDCard(c.IdCard))
                    throw new Exception("Incorrect data pertinent to ID card entered.");
                c.Address = txtCustAddress.Text;
                Customer updated = new Customer(txtCustName.Text, txtCustID.Text, txtCustAddress.Text);
                CustomerDL.editCust(c, updated);
                CustomerDL.writeCustomerFromFile();
                CustomerDL.readCustomerfromFile();
                Form frm = new CustomerMenu(c);
                frm.Show();
                this.Hide();
            }
            catch(Exception exp)
            {
                isUpdated = true;
                MessageBox.Show(exp.Message);
            }
        }
        private bool isCorrectIDCard(string idCard)
        {
            foreach(char c in idCard)
            {
                if (c < 48 || c > 57)
                    return false;
            }
            return true;
        }
        private bool isNumberIDCardCorrect(string idCard)
        {
            int count = 0;
            foreach(char c in idCard)
            {
                count++;
            }
            if(count == 13)
                 return true;

            return false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
