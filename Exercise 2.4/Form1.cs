namespace Exercise_2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "My first program";
            label1.Text = "G�rsel Programlamaya Ho�geldiniz";
            label1.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            label2.Text = "�sim: ";
            label2.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
            label3.Text = "G�rsel Programlamay� Sevdiniz mi?";
            label3.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
            checkBox1.Text = "Evet";
            button1.Text = "OK";
        }
    }
}
