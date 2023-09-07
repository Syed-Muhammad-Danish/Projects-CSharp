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
namespace CarRentalGUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            MUserDL.LoadFromFile();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void SignIN_Click(object sender, EventArgs e)
        {
            Form f1 = new SignIn();
            f1.Show();
            this.Hide();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form f1 = new SignUp();
            //f1.Show();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form f1 = new SignIn();
            //f1.Show();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new SignUp();
            f1.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new SignIn();
            f1.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CustomerDL.readCustomerfromFile();
        }
    }
}
