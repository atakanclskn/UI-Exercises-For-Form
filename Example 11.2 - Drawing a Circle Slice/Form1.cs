namespace Example_11._2___Drawing_a_Circle_Slice
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics a;
            SolidBrush brush = new SolidBrush(Color.Purple);
            Pen pen = new Pen(Color.Red, 5);
            a = this.CreateGraphics();

            a.FillEllipse(brush, 50, 50, 50, 50);
            
            a.DrawPie(pen, 46, 46, 100,100,0, 90);

            a.DrawLine(pen, 100, 100, 25, 25);

        }
        bool first = true;
        int x0, y0;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 5);
            if (first == true)
            {
                x0 = e.X;
                y0 = e.Y;
                first = false;
            }
            g.DrawLine(p, x0, y0, e.X, e.Y);
            x0 = e.X;y0 = e.Y;
        }
    }
}
