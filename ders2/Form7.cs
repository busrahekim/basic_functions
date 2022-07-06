using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox1.Text);
            int p = Convert.ToInt32(textBox2.Text);
            int ns = 0;

            if(p == 10)
            {
                ns = s + p * 7;
            }
            else if(p == 25)
            {
                ns = s + p * 15;
            }
            else if(p == 40)
            {
                ns = s + p * 25;
            }
            else
            {
                ns = s + p * 50;
            }

            textBox3.Text = ns.ToString();

        }
    }
}
