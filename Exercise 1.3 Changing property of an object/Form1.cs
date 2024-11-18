namespace Exercise_1._3_Changing_property_of_an_object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Width = 100;
            button1.Height = 100;
            button1.Left = +100;
            button1.Top = +100;
        }
    }
}
