namespace Exercise_7._6___ListBox_Object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //DISPLAY MAXIMUM
            int max = Convert.ToInt32(listBox1.Items[0]);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (Convert.ToInt32(listBox1.Items[i]) > Convert.ToInt32(listBox1.Items[0]))
                {
                    max = Convert.ToInt32(listBox1.Items[i]);
                }
            }
            MessageBox.Show($"Maximum:{Convert.ToString(max)}");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MOVE ITEM
            try
            {
                int i = listBox1.SelectedIndex;
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(i);
            }
            catch
            {
                MessageBox.Show("Please Select An Item!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //NEW ITEM
            listBox1.Items.Add(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //RESET
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //MOVE ITEM REVERSE
            try
            {
                int i = listBox2.SelectedIndex;
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(i);
            }
            catch
            {
                MessageBox.Show("Please Select An Item!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DISPLAY FIRST
            string s = Convert.ToString(listBox1.Items[0]);
            MessageBox.Show($"First Item: {s}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //DISPLAY LAST
            string s = Convert.ToString(listBox1.Items[listBox1.Items.Count - 1]);
            MessageBox.Show($"Last Item: {s}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //DISPLAY SELECTED
            string s = Convert.ToString(listBox1.SelectedItem);
            MessageBox.Show($"Selected Item: {s}");
        }

        private void button9_Click(object sender, EventArgs e)
        {

            //DISPLAY MINIMUM

            int min = Convert.ToInt32(listBox1.Items[0]);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (Convert.ToInt32(listBox1.Items[i]) < Convert.ToInt32(listBox1.Items[0]))
                {
                    min = Convert.ToInt32(listBox1.Items[i]);
                }
            }
            MessageBox.Show($"Minimum:{Convert.ToString(min)}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
