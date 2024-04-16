namespace SzamoloGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    SzámolóGomb b = new SzámolóGomb();
                    b.Left = i * 40;
                    b.Top = j * 40;

                    Controls.Add(b);
                }
            }
        }
    }
}