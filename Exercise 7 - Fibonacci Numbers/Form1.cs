namespace Exercise_7___Fibonacci_Numbers
{
    public partial class Form1 : Form
    {
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Fibonacci Numbers";
            this.Size = new Size(700, 1000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1 = new ListBox { Top = 150, Left = 350, Width = 250, Height = 500 };
            button1 = new Button { Text = "Generate", Top = 250, Left = 50, Width = 200, Height = 50 };
            textBox1 = new TextBox { Top = 150, Left = 50, Width = 200, Height = 50 };

            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) < 499)
            {
                listBox1.Items.Clear();
                int num = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();

                int s1 = 1;
                int s2 = 1;
                int s3;
                listBox1.Items.Add(s1);
                listBox1.Items.Add(s2);
                for (int i = 0; i < num; i++)
                {
                    s3 = s1 + s2;
                    s1 = s2;
                    s2 = s3;
                    listBox1.Items.Add(s3);

                }
            }
            else {
                MessageBox.Show("sakin!", "ERROR!");
            }
            
        }
    }
}
