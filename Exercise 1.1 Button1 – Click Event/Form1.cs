namespace Exercise_1._1_Button1___Click_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "My first program", MessageBoxButtons.OKCancel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
