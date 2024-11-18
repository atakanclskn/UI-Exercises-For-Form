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
            label1.Text = "Görsel Programlamaya Hoþgeldiniz";
            label1.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            label2.Text = "Ýsim: ";
            label2.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
            label3.Text = "Görsel Programlamayý Sevdiniz mi?";
            label3.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
            checkBox1.Text = "Evet";
            button1.Text = "OK";
        }
    }
}
