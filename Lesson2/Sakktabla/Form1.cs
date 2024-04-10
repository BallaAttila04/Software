namespace Sakktabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KirajzolSakktabla(8); // Sakktábla mérete 8x8-as
        }

        private void KirajzolSakktabla(int meret)
        {
            int negyzetMeret = 50; // Négyzetek mérete pixelben

            for (int sor = 0; sor < meret; sor++)
            {
                for (int oszlop = 0; oszlop < meret; oszlop++)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(negyzetMeret, negyzetMeret);
                    panel.Location = new Point(oszlop * negyzetMeret, sor * negyzetMeret);

                    if ((sor + oszlop) % 2 == 0) // Csak páros sorok és oszlopok
                    {
                        panel.BackColor = Color.Black; // Fekete négyzetek
                    }
                    else
                    {
                        panel.BackColor = Color.White; // Fehér négyzetek
                    }

                    Controls.Add(panel); // Hozzáadja a négyzetet a formhoz
                }
            }
        }
    }
}