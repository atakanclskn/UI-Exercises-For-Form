namespace Exercise_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Bir textbox oluþturarak isim soyadý yan yana yazdýrýnýz. */
            MessageBox.Show("Merhaba " + textBox1.Text + " " + textBox2.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        
    }
}
