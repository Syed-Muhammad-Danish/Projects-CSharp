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
    public partial class EditCar : Form
    {
        internal Car prev;
        public EditCar(Car prev)
        {
            InitializeComponent();
            this.prev = prev;
            textBox1.Text = prev.LicensePlate;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Car updated = new Car(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDouble(textBox4.Text), comboBox1.Text, Convert.ToDouble(textBox4.Text));
                CarDL.updateCar(prev, updated);
                CarDL.writeCarinFile();
                CarDL.clearList();
                CarDL.readCarFromFile();
                MessageBox.Show("Updated Successfully!");
                this.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void EditCar_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new AdminMenu();
            frm.Show();
            this.Hide();
        }
    }
}
