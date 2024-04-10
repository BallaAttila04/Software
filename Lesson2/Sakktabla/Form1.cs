namespace Sakktabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KirajzolSakktabla(8); // Sakkt�bla m�rete 8x8-as
        }

        private void KirajzolSakktabla(int meret)
        {
            int negyzetMeret = 50; // N�gyzetek m�rete pixelben

            for (int sor = 0; sor < meret; sor++)
            {
                for (int oszlop = 0; oszlop < meret; oszlop++)
                {
                    Panel panel = new Panel();
                    panel.Size = new Size(negyzetMeret, negyzetMeret);
                    panel.Location = new Point(oszlop * negyzetMeret, sor * negyzetMeret);

                    if ((sor + oszlop) % 2 == 0) // Csak p�ros sorok �s oszlopok
                    {
                        panel.BackColor = Color.Black; // Fekete n�gyzetek
                    }
                    else
                    {
                        panel.BackColor = Color.White; // Feh�r n�gyzetek
                    }

                    Controls.Add(panel); // Hozz�adja a n�gyzetet a formhoz
                }
            }
        }
    }
}