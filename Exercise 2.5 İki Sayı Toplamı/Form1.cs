namespace Exercise_2._5_İki_Sayı_Toplamı
{
    public partial class Form1 : Form
    {
        private TextBox textbox1;
        private TextBox textbox2;
        private Button button1;

        public Form1()
        {

            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            textbox1 = new TextBox();
            textbox2 = new TextBox();
            button1 = new Button();

            Controls.Add(textbox1);
            Controls.Add(textbox2);
            Controls.Add(button1);

            this.Text = "İki Sayı Topla";
            button1.Text = "Answer";
            button1.Location = new Point(200,100);
            button1.AutoSize = true;
            textbox1.Location = new Point(100, 25);
            textbox2.Location = new Point(300, 25);
            textbox1.AutoSize = true;

            button1.Click += Button1_Click;

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            double y = Convert.ToDouble(textbox1.Text); 
            double x = Convert.ToDouble(textbox2.Text);
            MessageBox.Show(Convert.ToString ( x + y));
        }
    }
}
