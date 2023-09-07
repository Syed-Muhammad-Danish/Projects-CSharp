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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MUser p = new MUser(textBox1.Text, textBox2.Text, "CUSTOMER");
            MUserDL.User.Add(p);
            MUserDL.writeInFile();
            MUserDL.LoadFromFile();
            MessageBox.Show("Registered successfully.");
            this.Close();
            Form frm = new FormMain();
            frm.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new FormMain();
            f1.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            Form frm = new FormMain();
            frm.Show();
            this.Hide();
        }

        private void SignUp_Load_1(object sender, EventArgs e)
        {

        }
    }
}
