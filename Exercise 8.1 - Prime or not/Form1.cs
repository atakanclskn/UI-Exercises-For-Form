namespace Exercise_8._1___Prime_or_not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            if (num <= 1)
            {
                MessageBox.Show("Not Prime", "Prime or Not?", MessageBoxButtons.OK);
                return;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    MessageBox.Show("Not Prime", "Prime or Not?", MessageBoxButtons.OK);
                    return;
                }
            }
            MessageBox.Show("Prime", "Prime or Not?", MessageBoxButtons.OK);
        }

    }
}

