namespace Exercise_3._3_Mini_Calculator
{


    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();


            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();

            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();

            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(textBox11);
            Controls.Add(textBox12);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);

            this.Text = "Mini Calculator";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.DarkSlateGray;
            this.Size = new Size(800,500);
            this.AutoSize = true;
            this.StartPosition = 0;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.TransparencyKey = Color.LightBlue;


            Panel titleBar = new Panel();
            titleBar.BackColor = Color.Transparent;
            titleBar.Dock = DockStyle.Fill;

            label1.Text = "Mini Calculator";
            label1.Font = new Font("Arial", 26, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(180, 30);
            label1.AutoSize = true;


            label2.Text = "+";
            label2.Location = new Point(150,150);
            label2.AutoSize = true;
            label2.Font = new Font("Arial",16, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;


            label3.Text = "-";
            label3.Location = new Point(155,220);
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;



            label4.Text = "*";
            label4.Location = new Point(155,295);
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.White;


            label5.Text = "/";
            label5.Location = new Point(160,362);
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;


            label6.Text = "=";
            label6.Location = new Point(340, 150);
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.White;


            label7.Text = "=";
            label7.Location = new Point(340, 220);
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.White;


            label8.Text = "=";
            label8.Location = new Point(340, 290);
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.White;


            label9.Text = "=";
            label9.Location = new Point(340, 360);
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.White;


            textBox1.Location = new Point(25,152);
            textBox1.AutoSize = true;
            textBox1.Size = new Size(100,10);

            textBox2.Location = new Point(210, 152);
            textBox2.AutoSize = true;
            textBox2.Size = new Size(100, 10);

            textBox3.Location = new Point(400, 152 );
            textBox3.AutoSize = true;
            textBox3.Size = new Size(100, 10);
            textBox3.ReadOnly = true;
            textBox4.Location = new Point(25, 222);
            textBox4.AutoSize = true;
            textBox4.Size = new Size(100, 10);

            textBox5.Location = new Point(210,222);
            textBox5.AutoSize = true;
            textBox5.Size = new Size(100, 10);

            textBox6.Location = new Point(400, 222);
            textBox6.AutoSize = true;
            textBox6.Size = new Size(100, 10);
            textBox6.ReadOnly = true;

            textBox7.Location = new Point(25,292);
            textBox7.AutoSize = true;
            textBox7.Size = new Size(100, 10);

            textBox8.Location = new Point(210, 292);
            textBox8.AutoSize = true;
            textBox8.Size = new Size(100, 10);

            textBox9.Location = new Point(400, 292);
            textBox9.AutoSize = true;
            textBox9.Size = new Size(100, 10);
            textBox9.ReadOnly = true;

            textBox10.Location = new Point(25, 362);
            textBox10.AutoSize = true;
            textBox10.Size = new Size(100, 10);

            textBox11.Location = new Point(210, 362);
            textBox11.AutoSize = true;
            textBox11.Size = new Size(100, 10);

            textBox12.Location = new Point(400, 362);
            textBox12.AutoSize = true;
            textBox12.Size = new Size(100, 10);
            textBox12.ReadOnly = true;

            button1.Size = new Size(210, 10);
            button1.Location = new Point(540, 150);
            button1.AutoSize = true;
            button1.Text = "Summary";
            button1.ForeColor = System.Drawing.Color.Black;
            button1.BackColor = System.Drawing.Color.White;
            button1.FlatStyle = FlatStyle.Standard;
            button1.FlatAppearance.BorderSize = 0;

            button2.Location = new Point(540, 220);
            button2.AutoSize = true;
            button2.ForeColor = System.Drawing.Color.Black;
            button2.BackColor = System.Drawing.Color.White;
            button2.Size = new Size(210, 10);
            button2.Text = "Substract";
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Standard;

            button3.Location = new Point(540, 290);
            button3.AutoSize = true;
            button3.Size = new Size(210, 10);
            button3.ForeColor = System.Drawing.Color.Black;
            button3.BackColor = System.Drawing.Color.White;
            button3.Text = "Multiply";
            button3.FlatStyle = FlatStyle.Standard;
            button3.FlatAppearance.BorderSize = 0;
             

            button4.Location = new Point(540, 360 );
            button4.AutoSize = true;
            button4.ForeColor = System.Drawing.Color.Black;
            button4.BackColor = System.Drawing.Color.White;
            button4.Size = new Size(210, 10);
            button4.Text = "Divide";
            button4.FlatStyle = FlatStyle.Standard;
            button4.FlatAppearance.BorderSize = 0;

            button1.MouseHover += Button1_MouseHover;
            button2.MouseHover += Button2_MouseHover;
            button3.MouseHover += Button3_MouseHover;
            button4.MouseHover += Button4_MouseHover;

            button1.MouseLeave += Button1_MouseLeave;
            button2.MouseLeave += Button2_MouseLeave;
            button3.MouseLeave += Button3_MouseLeave;
            button4.MouseLeave += Button4_MouseLeave;

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
                

        }

        private void Button4_Click(object? sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox10.Text); // TextBox4'ün içeriðini al ve double'a dönüþtür
                double y = Convert.ToDouble(textBox11.Text); // TextBox5'ün içeriðini al ve double'a dönüþtür

                textBox12.Text = $"{x / y}"; // Sonucu textBox6'ya yaz
                textBox10.Text = null;
                textBox11.Text = null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning); // Format hatasýný yakala ve kullanýcýya bildir
            }
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox7.Text); // TextBox4'ün içeriðini al ve double'a dönüþtür
                double y = Convert.ToDouble(textBox8.Text); // TextBox5'ün içeriðini al ve double'a dönüþtür

                textBox9.Text = $"{x * y}"; // Sonucu textBox6'ya yaz
                textBox7.Text =null ;
                textBox8.Text = null ;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning); // Format hatasýný yakala ve kullanýcýya bildir
            }
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox4.Text); // TextBox4'ün içeriðini al ve double'a dönüþtür
                double y = Convert.ToDouble(textBox5.Text); // TextBox5'ün içeriðini al ve double'a dönüþtür

                textBox6.Text = $"{x - y}"; // Sonucu textBox6'ya yaz
                textBox4.Text = null ;
                textBox5 .Text = null ;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning); // Format hatasýný yakala ve kullanýcýya bildir
            }
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text); // TextBox4'ün içeriðini al ve double'a dönüþtür
                double y = Convert.ToDouble(textBox2.Text); // TextBox5'ün içeriðini al ve double'a dönüþtür

                textBox3.Text = $"{x + y}"; // Sonucu textBox6'ya yaz
                textBox1.Text = null;
                textBox2.Text = null;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning); // Format hatasýný yakala ve kullanýcýya bildir
            }
        }

        private void Button1_MouseLeave(object? sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
        }

        private void Button1_MouseHover(object? sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.White;
        }
        private void Button2_MouseLeave(object? sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = System.Drawing.Color.Black;
        }

        private void Button2_MouseHover(object? sender, EventArgs e)
        {
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = Color.White;
        }
        private void Button3_MouseLeave(object? sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            button3.ForeColor = System.Drawing.Color.Black;
        }

        private void Button3_MouseHover(object? sender, EventArgs e)
        {
            button3.BackColor = Color.DarkSlateGray;
            button3.ForeColor = Color.White;
        }
        private void Button4_MouseLeave(object? sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.ForeColor = System.Drawing.Color.Black;
        }

        private void Button4_MouseHover(object? sender, EventArgs e)
        {
            button4.BackColor = Color.DarkSlateGray;
            button4.ForeColor = Color.White;
        }
    }
}
