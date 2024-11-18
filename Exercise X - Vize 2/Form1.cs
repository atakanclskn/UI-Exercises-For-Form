namespace Exercise_X___Vize_2
{
    public partial class Form1 : Form
    {
        TextBox textBox1;
        Button button1;
        ListBox listBox1;
        Label label1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();

            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);

            this.Text = "Vize Sorusu";
            this.Size = new System.Drawing.Size(500, 500 );


            button1.Text = "Hesapla";
            button1.Size = new Size(100, 100);
            button1.Location = new Point(100, 100);
            button1.AutoSize = true;

            label1.Text = "Para Banknot Bölücü";
            label1.Location = new Point(10, 10);
            label1.AutoSize = true;

            listBox1.Location = new Point(100, 200);
            listBox1 .AutoSize = true;

            textBox1.Location = new Point(100, 50);

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int x5 = x / 5 ;
            int x10 = x / 10;
            int x20 = x / 20;
            int x50 = x / 50;
            int x100 = x / 100;
            int x200 = x / 200;


            listBox1.Items.Add(x200);
            listBox1.Items.Add(x100);
            listBox1.Items.Add(x50);
            listBox1.Items.Add(x20);
            listBox1.Items.Add(x10);
            listBox1.Items.Add(x5);

            textBox1.Clear();
        }
    }
}
