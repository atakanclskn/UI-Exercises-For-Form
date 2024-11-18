namespace Exercise_X___Vize_3
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private Button button1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Vize Sorularý 3";
            this.Size = new Size(230, 250);
            button1 = new Button();
            textBox1 = new TextBox();

            Controls.Add(button1);
            Controls.Add(textBox1);

            button1.Text = "Hesapla";
            button1.Size = new Size(100, 10);
            button1.ForeColor = System.Drawing.Color.White;
            button1.BackColor = Color.Black;
            button1.Location = new Point(50, 100);
            textBox1.Location = new Point(50, 50);
            button1.AutoSize = true;

            button1.Click += Button1_Click;

        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            int y = Convert.ToInt16(textBox1.Text);
            bool x = DateTime.IsLeapYear(Convert.ToInt32(textBox1.Text));
            
            MessageBox.Show($"{x}",$"{y} yýlý Artýk Yýl Mý?",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }
    }
}
