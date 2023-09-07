using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalGUI.DL;
using CarRentalGUI.BL;
namespace CarRentalGUI
{
    public partial class SignIn : Form
    {
        internal string role;
        //internal Customer c;
        public SignIn()
        {
            InitializeComponent();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MUser p = MUserDL.getReference(txtUserName.Text, txtPassword.Text);
            if(p != null)
            {
                role = p.Role;
                if(role == "ADMIN")
                {
                    Form frm = new AdminMenu();
                    frm.Show();
                    this.Hide();
                }
                else if(role == "CUSTOMER")
                {
                    Customer c = new Customer(p.Username);
                    CustomerDL.addCust(c);
                   // Customer check = MUserDL.fetchCustomer(c);
                    Form frm = new CustomerMenu(c);
                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frm = new FormMain();
            this.Hide();
            frm.Show();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
