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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Car c = new Car(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDouble(textBox4.Text), comboBox1.Text, Convert.ToDouble(textBox4.Text));
                CarDL.addCar(c);
                CarDL.writeCarinFile();
                CarDL.readCarFromFile();
                MessageBox.Show("Car Added Successfully!");
                this.Hide();
                Form frm = new AdminMenu();
                frm.Show();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new AdminMenu();
            this.Hide();
            frm.Show();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            CarDL.readCarFromFile();
        }
    }
}
