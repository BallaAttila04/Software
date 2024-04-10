namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                Button b = new Button();
                b.Top = i * 30;
                b.Text = Fibonacci(i).ToString();
                Controls.Add(b);
            }

            List<Elem> elemek = new List<Elem>();
            for (int i = 0; i < 10; i++)
            {
                elemek.Add(new Elem { Sorszam = i, Ertek = Fibonacci(i) });
            }
            dataGridView1.DataSource = elemek;
        }
    }
}