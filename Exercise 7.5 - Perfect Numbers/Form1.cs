namespace Exercise_7._5___Perfect_Numbers
{
    public partial class Form1 : Form
    {
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Perfect Numbers";
            this.Size = new Size(700, 1000);
            this.AcceptButton = button1;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.CancelButton = button1;
            this.Cursor = Cursors.PanNorth;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Opacity =  0.8 ;
            this.ShowInTaskbar = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1 = new ListBox { Top = 150, Left = 350, Width = 250, Height = 500, Anchor = AnchorStyles.Bottom };
            button1 = new Button { Text = "Generate", Top = 250, Left = 50, Width = 200, Height = 50, Anchor = AnchorStyles.Bottom };
            textBox1 = new TextBox { Top = 150, Left = 50, Width = 200, Height = 50, Anchor = AnchorStyles.Bottom};

            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int n = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= n; i++)
            {
                int t = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        t += j;
                    }
                }
                if (i == t)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
