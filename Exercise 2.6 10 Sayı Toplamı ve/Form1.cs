namespace Exercise_2._6_10_Sayı_Toplamı_ve
{
    public partial class Form1 : Form
    {
        ListBox listBox1;
        TextBox textBox1;
        Label label1;
        Label label2;
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();

            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);

            this.Text = "X";
            this.Size = new System.Drawing.Size(320, 420);
            this.AutoSize = true;
            this.StartPosition = 0;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            listBox1.Location = new Point(20, 120);
            listBox1.Name = "List Box";
            listBox1.Size = new Size(100, 240);
            
            label1.Location = new Point(0, 20);
            label1.AutoSize = true;
            
            label2.Location = new Point(20, 75);
            label2.AutoSize = true;
            
            textBox1.Location = new Point(170, 70);
            
            button1.Location = new Point(170, 120);
            button1.AutoSize = true;
            button1.Size = new Size(100, 10);
            
            button2.Location = new Point(170, 180);
            button2.AutoSize = true;
            button2.Size = new Size(100, 10);
            
            button3.Location = new Point(170, 240);
            button3.AutoSize = true;
            button3.Size = new Size(100, 10);
            
            button4.Location = new Point(170, 300);
            button4.AutoSize = true;
            button4.Size = new Size(100, 10);

            label1.Text = "10 Sayı Toplamı ve Ortalaması";
            label1.Font = new Font("Arial",10, FontStyle.Bold);
            label2.Text = "Sayı Gir   :";
            label2.Font = new Font("Arial",9, FontStyle.Bold);
            button1.Text = "Ekle";
            button2.Text = "Toplam";
            button3.Text = "Ortalama";
            button4.Text = "Temizle";

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
        }

        private void Button4_Click(object? sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            double total = 0;
            int count = 0;

            foreach (var item in listBox1.Items)
            {
                if (double.TryParse(item.ToString(), out double number)) 
                {
                    total += number;
                    count++;
                }
            }

            double average = count > 0 ? total / count : 0;

            MessageBox.Show("Ortalama: " + average.ToString(), "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            double total = 0;

            foreach (var item in listBox1.Items)
            {
                if (double.TryParse(item.ToString(), out double number)) 
                {
                    total += number;
                }
            }

            MessageBox.Show("Toplam: " + total.ToString(), "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number)) 
            {
                listBox1.Items.Add(number);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
