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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mid = Convert.ToInt32(textBox1.Text);
            int final = Convert.ToInt32(textBox1.Text);

            double score = (mid * 0.4 + final * 0.6);

            if(score >= 60)
            {
                MessageBox.Show("You passed!");
            }
            else
            {
                MessageBox.Show("You failed!");
            }
        }
    }
}
