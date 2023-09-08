using System.Text;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string num0 = "0";
        string num1 = "1";
        string num2 = "2";
        string num3 = "3";
        string num4 = "4";
        string num5 = "5";
        string num6 = "6";
        string num7 = "7";
        string num8 = "8";
        string num9 = "9";
        string val = "";
        string div = "/";
        string pl = "+";
        string min = "-";
        string mult = "*";
        
        public Form1()
        {
            InitializeComponent();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            /*Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            // Generate 10 random numbers and store them in a StringBuilder.
            for (int ctr = 0; ctr <= 9; ctr++)
                sb.Append("Danish ");

            MessageBox.Show(sb.ToString());*/
            val = "";
            display.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            val = val + div;
            display.Text = val;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            val = val + mult;
            display.Text = val;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            val = val + num7;
            display.Text = val;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            val = val + num8;
            display.Text = val;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            val = val + num9;
            display.Text = val;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            val = val + pl;
            display.Text = val;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            val = val + num4;
            display.Text = val;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            val = val + num5;
            display.Text = val;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            val = val + num6;
            display.Text = val;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            val = val + min;
            display.Text = val;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            val = val + num1;
            display.Text = val;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            val = val + num2;
            display.Text = val;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            val = val + num3;
            display.Text = val;

        }

        private void dot_Click(object sender, EventArgs e)
        {
            val = val + ".";
            display.Text = val;

        }

        private void guna2CircleButton19_Click(object sender, EventArgs e)
        {
            val = val + num0;
            display.Text = val;

        }
    }
}