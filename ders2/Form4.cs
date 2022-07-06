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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            int s3 = Convert.ToInt32(textBox3.Text);

            if (s1 == s2 && s2 == s3)
            {
                MessageBox.Show("Eşkenar");
            }
            else if ((s1 == s2 && s2 != s3) || (s1 == s3 && s1 != s2) || (s2 == s3 && s1 != s2))
            {
                MessageBox.Show("İkizkenar");
            }
            else
            {
                MessageBox.Show("Çeşitkenar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
