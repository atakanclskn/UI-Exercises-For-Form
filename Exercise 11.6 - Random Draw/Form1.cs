namespace Exercise_11._6___Random_Draw
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Random r = new Random();
            Graphics g;
            Pen k = new Pen(Color.Cyan ,8);
            SolidBrush f = new SolidBrush(Color.White);
            Point[] cizgiler = new Point[3];
            g = this.CreateGraphics();
            cizgiler[0].X = r.Next(450);
            cizgiler[0].Y = r.Next(450);
            cizgiler[1].X = r.Next(450);
            cizgiler[1].Y = r.Next(450);
            cizgiler[2].X = r.Next(450);
            cizgiler[2].Y = r.Next(450);
            g.DrawLines(k, cizgiler);






        }
    }
}
