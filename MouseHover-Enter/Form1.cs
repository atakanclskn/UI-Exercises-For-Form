namespace MouseHover_Enter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(5);
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           listBox1.Items.Add("Item 1");
            listBox1.Items.Add("Item 2");
            listBox1.Items.Add("Item 3");
            listBox1.Items.Add("Item 4");
            listBox1.Items.Add("Item 4");
            listBox1.Items.Add("Item 4");
            listBox1.Items.Add("Item 7");
            listBox1.Items.Add("Item 8");
            listBox1.Items.Add("Item 9");
            listBox1.Items.Add("Item 10");

            listBox1.MultiColumn = true;
            listBox1.SelectionMode = SelectionMode.MultiSimple;

            button1.Click += button1_Click;
            button1.MouseHover += button1_MouseHover;
            button1.MouseEnter += button1_MouseEnter;
            button2.Click += button2_Click;

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
