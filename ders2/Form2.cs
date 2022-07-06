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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;

            int num = Convert.ToInt32(textBox1.Text);

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    c++;
            }

            if (c != 0)
                MessageBox.Show("Not a prime number.");
            else
                MessageBox.Show("It is a prime number.");

            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
