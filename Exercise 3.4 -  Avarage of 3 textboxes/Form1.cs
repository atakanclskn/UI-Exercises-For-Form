namespace Exercise_3._4____Avarage_of_3_textboxes
{
    public partial class Form1 : Form
    {
        TextBox textBox1;
        TextBox textBox2;
        TextBox textBox3;
        Label label1;
        Button button1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            button1 = new Button();

            this.Controls.Add(label1);
            this.Controls.Add(button1);
            this.Controls.Add(textBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox3);
            this.Size = new Size(120, 300);
            this.Cursor = Cursors.Hand;
            this.AutoSize = true;
            this.

            textBox1.Location = new Point(30, 50);
            textBox1.Size = new Size(100, 10);

            textBox2.Location = new Point(30, 100);
            textBox2.Size = new Size(100, 10);

            textBox3.Location = new Point(30, 150);
            textBox3.Size = new Size(100, 10);


            label1.Location = new Point(5, 10);
            label1.Text = "Avarage Finder";
            label1.AutoSize = true;
            label1.Font = new Font("Ariel", 10, FontStyle.Bold);

            button1.Location = new Point(30, 200);
            button1.Size = new Size(100, 10);
            button1.Text = "Avarage";
            button1.AutoSize = true;

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = Convert.ToDouble(textBox3.Text);

                MessageBox.Show($"Avarage:{(x + y + z) / 3}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch 
            {
                MessageBox.Show("Enter valid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
