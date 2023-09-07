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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void lblback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form frm = new AdminMenu();
            frm.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MUser user = new MUser(txtUsername.Text,txtPassword.Text,comboBox1.Text);
            MUserDL.addintoList(user);
            MessageBox.Show("User Added Successfully!");

            Form frm = new AdminMenu();
            this.Hide();
            frm.Show();
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
