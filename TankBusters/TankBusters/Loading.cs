using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TankBusters
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value += 10;
            if (guna2ProgressBar1.Value >= 100)
            {

                this.Hide();
                this.timer1.Stop();
                Form2 f = new Form2();
                f.Show();



            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
