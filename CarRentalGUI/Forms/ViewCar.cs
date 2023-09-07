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
    public partial class ViewCar : Form
    {
        public ViewCar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Car prev = (Car)ViewCarGV.CurrentRow.DataBoundItem; //type casting
            if(ViewCarGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                Form frm = new EditCar(prev);
                this.Hide();
                frm.ShowDialog();
                dataBind();
                frm.Hide();
                this.Show();
            }
            else if(ViewCarGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                CarDL.deleteCar(prev);
                dataBind();
                MessageBox.Show("Deleted Successfully!");
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void dataBind()
        {
            ViewCarGV.DataSource = null;
            ViewCarGV.DataSource = CarDL.Cars;
            ViewCarGV.Refresh();
        }

        private void ViewCar_Load(object sender, EventArgs e)
        {
            CarDL.readCarFromFile();
            ViewCarGV.DataSource = CarDL.Cars;//introspection
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new AdminMenu();
            this.Hide();
            frm.Show();
        }
    }
}
