namespace Exercises_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            MessageBox.Show(textBox1.Text, textBox1.Text, MessageBoxButtons.OKCancel);
            label1.Text = textBox1.Text;
            button1.Text = textBox1.Text;
        }
    }
}
