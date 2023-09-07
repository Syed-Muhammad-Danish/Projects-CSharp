using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankBusters
{
    public partial class Form3 : Form
    {
        int count = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 3)
            {
                this.Dispose();
            }
        }
    }
}
