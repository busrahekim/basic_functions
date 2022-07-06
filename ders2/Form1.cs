namespace ders2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int a = Convert.ToInt32(sayi1.Text);
            int a = int.Parse(sayi1.Text);
            int b = int.Parse(sayi2.Text);
            int sum = a + b;
            label4.Text = sum.ToString();

            sayi1.Clear();
            sayi2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(sayi1.Text);
            int b = int.Parse(sayi2.Text);
            int dif = a-b;
            label4.Text = dif.ToString();

            sayi1.Clear();
            sayi2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(sayi1.Text);
            double b = Convert.ToDouble(sayi2.Text);
            double div = a/b;
            label4.Text = div.ToString();

            sayi1.Clear();
            sayi2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(sayi1.Text);
            int b = int.Parse(sayi2.Text);
            int mul = a * b;
            label4.Text = mul.ToString();

            sayi1.Clear();
            sayi2.Clear();

            MessageBox.Show("Sonuç : "+ mul.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(sayi1.Text);
            int b = int.Parse(sayi2.Text);
            int mod = a % b;
            label4.Text = mod.ToString();

            sayi1.Clear();
            sayi2.Clear();

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}