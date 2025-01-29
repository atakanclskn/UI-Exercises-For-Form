namespace Exercise_9._1___Random_Generator
{
    public partial class Form1 : Form
    {
        private Label label;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Button buttonOK;
        private ComboBox comboBox1;

        private int min;
        private int max;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Random Number Generator";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label = new Label
            {
                Text = " RANDOM NUMBERS ",
                Top = 50,
                Left = 195,
                AutoSize = true,
                Font = new Font("Arial", 16)
            };

            button1 = new Button
            {
                Text = "Generate",
                Top = 100,
                Left = 400,
                Width = 200,
                Height = 37
            };

            textBox1 = new TextBox
            {
                Top = 100,
                Left = 200,
                Width = 200,
                Height = 43
            };

            listBox1 = new ListBox
            {
                Top = 150,
                Left = 50,
                Width = 700,
                Height = 150,
                BorderStyle = BorderStyle.None,
                BackColor = Color.Gray,
                MultiColumn = true,
            };

            buttonOK = new Button
            {
                Text = "OK",
                Top = 350,
                Left = 450,
                Width = 100,
                Height = 40,
            };

            comboBox1 = new ComboBox
            {
                Top = 350,
                Left = 200,
                Width = 200,
                Height = 70,
            };
            comboBox1.Items.Add("Mean");
            comboBox1.Items.Add("Max");
            comboBox1.Items.Add("Min");
            comboBox1.Items.Add("Range");

            Controls.Add(label);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(buttonOK);
            Controls.Add(comboBox1);

            button1.Click += Button1_Click;
            buttonOK.Click += ButtonOK_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < n; i++)
            {
                listBox1.Items.Add(random.Next(100).ToString());
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Mean")
            {
                int sum = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sum += Convert.ToInt32(listBox1.Items[i]);
                }
                MessageBox.Show($"Mean: {Convert.ToString(sum / listBox1.Items.Count)}");
            }
            else if (comboBox1.SelectedItem == "Max")
            {
                max = Convert.ToInt32(listBox1.Items[0]);
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) > max)
                    {
                        max = Convert.ToInt32(listBox1.Items[i]);
                    }
                }
                MessageBox.Show($"Maximum: {Convert.ToString(max)}");
            }
            else if (comboBox1.SelectedItem == "Min")
            {
                min = Convert.ToInt32(listBox1.Items[0]);
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) < min)
                    {
                        min = Convert.ToInt32(listBox1.Items[i]);
                    }
                }
                MessageBox.Show($"Minimum: {Convert.ToString(min)}");
            }
            else if (comboBox1.SelectedItem == "Range")
            {
                MessageBox.Show($"Range: {Convert.ToString(max - min)}");
            }
        }
    }
}



    
    

