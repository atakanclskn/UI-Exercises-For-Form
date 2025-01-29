namespace Example_11._5___Random_DrawCurve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            //this.MouseClick += new MouseEventHandler(Form1_MouseClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics;
            Pen kalem = new Pen(Color.Red, 8);
            SolidBrush firca = new SolidBrush(Color.Cyan);
            Point[] cizgiler = new Point[3];
            graphics = this.CreateGraphics();
            cizgiler[0].X = 30;
            cizgiler[0].Y = 80;
            cizgiler[1].X = 145;
            cizgiler[1].Y = 78; 
            cizgiler[2].X = 90;
            cizgiler[2].Y = 187;
            graphics.DrawPolygon(kalem, cizgiler);
            graphics.FillClosedCurve(firca, cizgiler);
        }

    }
}
