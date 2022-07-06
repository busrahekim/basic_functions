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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int salary = Convert.ToInt32(textBox1.Text);
            if (salary <= 10000)
            {
                double s = salary - (salary * 0.1);
                textBox1.Text = s.ToString();
            }
            else if (salary <= 12000)
            {
                double s = salary - (salary * 0.15);
                textBox1.Text = s.ToString();
            }
            else
            {
                double s = salary - (salary * 0.2);
                textBox1.Text = s.ToString();
            }
        }
    }
}
