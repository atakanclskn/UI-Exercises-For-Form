namespace ListBox_BackColor_Change
{
    public partial class Form1 : Form
    {
        private ListBox listBox1;
        private Button button1;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            listBox1 = new ListBox
            {
                Top = 20,
                Left = 20,
                Width = 200,
                Height = 200
            };
            listBox1.Items.AddRange(new string[]
            {
                    "Red", "Green", "Blue", "Yellow", "Orange", "Purple", "Pink", "Brown", "Gray", "Black",
                    "White", "Cyan", "Magenta", "Lime", "Maroon"
            });

            button1 = new Button
            {
                Text = "Change Background Color",
                Top = 240,
                Left = 20,
                AutoSize = true
            };
            button1.Click += button1_Click;

            Controls.Add(listBox1);
            Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedColor = listBox1.SelectedItem.ToString();
                switch (selectedColor)
                {
                    case "Red":
                        this.BackColor = Color.Red;
                        break;
                    case "Green":
                        this.BackColor = Color.Green;
                        break;
                    case "Blue":
                        this.BackColor = Color.Blue;
                        break;
                    case "Yellow":
                        this.BackColor = Color.Yellow;
                        break;
                    case "Orange":
                        this.BackColor = Color.Orange;
                        break;
                    case "Purple":
                        this.BackColor = Color.Purple;
                        break;
                    case "Pink":
                        this.BackColor = Color.Pink;
                        break;
                    case "Brown":
                        this.BackColor = Color.Brown;
                        break;
                    case "Gray":
                        this.BackColor = Color.Gray;
                        break;
                    case "Black":
                        this.BackColor = Color.Black;
                        break;
                    case "White":
                        this.BackColor = Color.White;
                        break;
                    case "Cyan":
                        this.BackColor = Color.Cyan;
                        break;
                    case "Magenta":
                        this.BackColor = Color.Magenta;
                        break;
                    case "Lime":
                        this.BackColor = Color.Lime;
                        break;
                    case "Maroon":
                        this.BackColor = Color.Maroon;
                        break;
                    default:
                        MessageBox.Show("Unknown color selected.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a color from the list.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Diðer baþlangýç kodlarý burada olabilir
        }
    }
}
