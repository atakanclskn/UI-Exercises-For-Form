namespace Exercise_12._2.___Panel
{
    public partial class Form1 : Form
    {
        private Button button1;
        private Button button2;
        private Panel panel1;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Exercise 12.2. Panel";
            this.Size = new System.Drawing.Size(500,500);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             button1 = new Button 
                { 
                Text = "Draw Rectangle",
                Top = 375, Left= 50,
                Width = 175,Height = 40,
                };
             button2 = new Button 
                {
                Text = "Draw Ellipse",
                Top = 375, Left = 250,
                Width = 175, Height = 40 
                };
             panel1 = new Panel 
                {
                Top = 75,
                Left = 50,
                Width = 300,
                Height = 300
            };
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(button2);

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(randomColors[rand.Next(0, 3)], 3);
            int rw = rand.Next(20, 51);
            int rh = rand.Next(20, 51);
            int h = panel1.Height;
            int w = panel1.Width;
            g.DrawEllipse(p, rand.Next(1, w - rw), rand.Next(1, h - rh), rw, rh);
        }

        Color[] randomColors = {Color.Red, Color.Green, Color.Blue};
        Random rand = new Random();


        private void Button1_Click(object? sender, EventArgs e)
        {
            Graphics y = panel1.CreateGraphics();
            Pen p = new Pen(randomColors[rand.Next(0,3)], 6);
            int rw = rand.Next(20,51);
            int rh = rand.Next(20, 51);
            int h = panel1.Height;
            int w = panel1.Width;
            y.DrawRectangle(p, rand.Next(1,w-rw), rand.Next(1,h-rh), rw, rh);
        }
    }
}
