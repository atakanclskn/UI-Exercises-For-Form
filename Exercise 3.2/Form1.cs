namespace Exercise_3._2
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new Size(220, 260); // Formun boyutunu butona kadar küçült
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1 = new TextBox { Location = new Point(10, 10), Size = new Size(200, 40) };
            textBox2 = new TextBox { Location = new Point(10, 60), Size = new Size(200, 40) };
            textBox3 = new TextBox { Location = new Point(10, 110), Size = new Size(200, 40), ReadOnly = true };
            button1 = new Button { Location = new Point(10, 200), Size = new Size(200, 40), Text = "SUM" };

            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(button1);

            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();
        }
    }
}
