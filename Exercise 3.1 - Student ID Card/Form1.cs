namespace Exercise_3._1___Student_ID_Card
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;

        private Label label7;
        private Label label8;

        private CheckBox checkBox1;
        private CheckBox checkBox2;

        private Button button1;
        private Button buttonSend;
        private PictureBox pictureBox1;

        public Form1()
        {
            InitializeComponent();
            this.Text = "STUDENT ID CARD";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1 = new TextBox { Width = 200, Height = 35, Left = 200, Top = 40 };
            textBox2 = new TextBox { Width = 200, Height = 35, Left = 200, Top = 90 };
            textBox3 = new TextBox { Width = 200, Height = 35, Left = 200, Top = 140 };
            textBox4 = new TextBox { Width = 200, Height = 35, Left = 200, Top = 190 };
            textBox5 = new TextBox { Width = 200, Height = 35, Left = 200, Top = 290 };
            textBox6 = new TextBox { Width = 200, Height = 35, Left = 200, Top = 240 };

            label1 = new Label { Text = "NAME:", Left = 20, Top = 40, Width = 220, Height = 35 };
            label2 = new Label { Text = "SURNAME:", Left = 20, Top = 90, Width = 220, Height = 35 };
            label3 = new Label { Text = "STUDENT NO:", Left = 20, Top = 140, Width = 220, Height = 35 };
            label4 = new Label { Text = "SCHOOL:", Left = 20, Top = 190, Width = 220, Height = 35 };
            label5 = new Label { Text = "DEPARTMENT:", Left = 20, Top = 290, Width = 220, Height = 35 };
            label6 = new Label { Text = "FACULTY:", Left = 20, Top = 240, Width = 220, Height = 35 };

            checkBox1 = new CheckBox { Text = "MALE", Left = 200, Top = 340, Width = 100, Height = 35 };
            checkBox2 = new CheckBox { Text = "FEMALE", Left = 300, Top = 340, Width = 120, Height = 35 };

            pictureBox1 = new PictureBox { Left = 450, Top = 40, Width = 300, Height = 300, BorderStyle = BorderStyle.FixedSingle };
            button1 = new Button { Text = "UPLOAD PHOTO", Left = 450 + (300 - 120) / 2, Top = 350, Width = 120, Height = 35 };
            buttonSend = new Button { Text = "SEND", Left = 200, Top = 390, Width = 200, Height = 50 };

            pictureBox1.Paint += PictureBox1_Paint;

            button1.Click += Button1_Click;
            buttonSend.Click += ButtonSend_Click;

            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;

            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);

            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);

            Controls.Add(checkBox1);
            Controls.Add(checkBox2);

            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(buttonSend);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == checkBox1 && checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
            else if (sender == checkBox2 && checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Invalidate();
                }
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            string gender = checkBox1.Checked ? "MALE" : checkBox2.Checked ? "FEMALE" : "NOT SPECIFIED";
            string message = $"Name: {textBox1.Text}\nSurname: {textBox2.Text}\nStudent No: {textBox3.Text}\nFaculty: {textBox6.Text}\nDepartment: {textBox5.Text}\nGender: {gender}";

            Form cardForm = new Form
            {
                Width = 700,
                Height = 400,
                Text = "STUDENT ID CARD"
            };

            Label schoolLabel = new Label
            {
                Text = textBox4.Text,
                Font = new Font("Arial", 15, FontStyle.Bold),
                Left = 10,
                Top = 10,
                Width = 680,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label infoLabel = new Label
            {
                Text = $"{textBox1.Text}\n{textBox2.Text}\n{textBox3.Text}\n{textBox6.Text}\n{textBox5.Text}\n{gender}",
                Left = 10,
                Top = 80,
                Width = 350,
                Height = 300
            };

            PictureBox cardPictureBox = new PictureBox
            {
                Left = 370,
                Top = 50,
                Width = 300,
                Height = 300,
                BorderStyle = BorderStyle.FixedSingle,
                Image = pictureBox1.Image,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            cardForm.Controls.Add(schoolLabel);
            cardForm.Controls.Add(infoLabel);
            cardForm.Controls.Add(cardPictureBox);
            cardForm.ShowDialog();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                using (Font myFont = new Font("Arial", 14))
                {
                    e.Graphics.DrawString("NO PHOTO", myFont, Brushes.Black, new Point(80, 130));
                }
            }
        }
    }
}
