namespace Exercise_3._5___Small_Survey
{
    public partial class Form1 : Form
    {
        private Label label;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox21;
        private CheckBox checkBox22;
        private CheckBox checkBox23;
        private CheckBox checkBox31;
        private CheckBox checkBox32;
        private CheckBox checkBox33;
        private CheckBox checkBox41;
        private CheckBox checkBox42;
        private CheckBox checkBox43;

        private Button button1;


        public Form1()
        {
            InitializeComponent();
            this.Text = "Small Survey";
            this.Size = new Size(1000, 730);
            this.BackColor = Color.DarkOrange;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label = new Label 
            { Text = "ARE YOU A SPEED FREAK ?", 
                AutoSize = true,
                Top = 50, Left = 250 ,
                ForeColor = Color.Blue,
                Font = new Font("Arial", 15, FontStyle.Bold)
            }; 
            label1 = new Label { Text = "How often do you drive?", AutoSize = true, Top = 180, Left = 50 , ForeColor = Color.Black, Font = new Font("Arial", 10, FontStyle.Bold) };
            label2 = new Label { Text = "What is your maximum speed?", AutoSize = true, Top = 280, Left = 50, ForeColor = Color.Black, Font = new Font("Arial", 10, FontStyle.Bold) };
            label3 = new Label { Text = "What kind of cars interest you?", AutoSize = true, Top = 380, Left = 50, ForeColor = Color.Black, Font = new Font("Arial", 10, FontStyle.Bold) };
            label4 = new Label { Text = "On which roads do you drive fast?", AutoSize = true, Top = 480, Left = 50, ForeColor = Color.Black, Font = new Font("Arial", 10, FontStyle.Bold) };

            button1 = new Button { Text = "Next Page", Left = 400, Top = 580, Width = 200, Height = 50, BackColor = Color.Transparent, Font = new Font("monospace", 10, FontStyle.Bold)  };

            checkBox11 = new CheckBox { Text = "Once A Week", AutoSize = true, Top = 180, Left = 500, Font = new Font("monospace", 5, FontStyle.Bold) };
            checkBox12 = new CheckBox { Text = "Everyday", AutoSize = true, Top = 180, Left = 650, Font = new Font("monospace", 5, FontStyle.Bold) };
            checkBox13 = new CheckBox { Text = "Once A Month", AutoSize = true, Top = 180, Left = 800, Font = new Font("monospace", 5, FontStyle.Bold) };
            checkBox21 = new CheckBox {Text = "Under 160", AutoSize = true, Top = 280, Left = 500, Font = new Font("monospace", 5, FontStyle.Bold) };
            checkBox22 = new CheckBox {Text = "160-200", AutoSize = true, Top = 280, Left = 650, Font = new Font("monospace", 5, FontStyle.Bold) };
            checkBox23 = new CheckBox {Text = "More Than 200", AutoSize = true, Top = 280, Left = 800, Font = new Font("monospace", 5, FontStyle.Bold) };
            checkBox31 = new CheckBox {Text = "Fast", AutoSize = true, Top = 380, Left = 500, Font = new Font("monospace", 5, FontStyle.Bold) };
            checkBox32 = new CheckBox {Text = "Comfort", AutoSize = true, Top = 380, Left = 650, Font = new Font("monospace", 5, FontStyle.Bold) };
            checkBox33 = new CheckBox {Text = "Safe", AutoSize = true, Top = 380, Left = 800, Font = new Font("monospace", 5, FontStyle.Bold) };
            checkBox41 = new CheckBox {Text = "On Every Road", AutoSize = true, Top = 480, Left = 500, Font = new Font("monospace", 5, FontStyle.Bold) };
            checkBox42 = new CheckBox {Text = "On The Highway", AutoSize = true, Top = 480, Left = 650, Font = new Font("monospace", 5, FontStyle.Bold) };
            checkBox43 = new CheckBox {Text = "Open Field", AutoSize = true, Top = 480, Left = 800, Font = new Font("monospace", 5, FontStyle.Bold) };

            Controls.Add(label);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            
            Controls.Add(button1);
            
            Controls.Add(checkBox11);
            Controls.Add(checkBox12);
            Controls.Add(checkBox13);
            Controls.Add(checkBox21);
            Controls.Add(checkBox22);
            Controls.Add(checkBox23);
            Controls.Add(checkBox31);
            Controls.Add(checkBox32);
            Controls.Add(checkBox33);
            Controls.Add(checkBox41);
            Controls.Add(checkBox42);
            Controls.Add(checkBox43);
            





        }
    }
}
