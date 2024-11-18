namespace Exercise_X___Vize_1
{

    public partial class Form1 : Form
    {
        TextBox textBox1;
        TextBox textBox2;
        Button button1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();

            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);

            this.Size = new Size(500, 200);
            this.Text = "Vize Sorusu 1";

            textBox1.Location = new Point(100, 62);
            textBox2.Location = new Point(290, 62);
            textBox2.Size = new Size(160,10);

            button1.Text = "Hesapla";
            button1.BackColor = Color.Yellow;
            button1.AutoSize = true;
            button1.Location = new Point(200, 60);



            button1.Click += Button1_Click;


        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);

                if (x % 5 == 0)
                {
                    textBox2.Text = $"{x}/5 = {x/5}";
                }
                else
                {
                    textBox2.Text = "5'e Bölünemez!";
                }
            }
            catch
            {
                MessageBox.Show("Lütfen gecerli bir deger giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }
   }

