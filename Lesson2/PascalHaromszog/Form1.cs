using System;
using System.Windows.Forms;

namespace PascalHaromszog
{
    public partial class Form1 : Form
    {
        int Faktorialis(int n)
        {
            int eredm�ny = 1;
            for (int i = 1; i <= n; i++) eredm�ny *= i;
            return eredm�ny;
        }

        public Form1()
        {
            InitializeComponent();
            int buttonSize = 60; // Gomb m�rete
            int startX = (ClientRectangle.Width - 10 * buttonSize) / 2; // Kezd� poz�ci� X tengelyen
            int startY = 50; // Kezd� poz�ci� Y tengelyen

            for (int sor = 0; sor < 10; sor++)
            {
                int offset = (10 - sor - 1) * buttonSize / 2; // Balra tol�s mennyis�ge

                for (int oszlop = 0; oszlop <= sor; oszlop++)
                {
                    Button b = new Button();
                    b.Top = startY + sor * buttonSize;
                    b.Left = startX + offset + oszlop * buttonSize;
                    b.Height = buttonSize;
                    b.Width = buttonSize;
                    this.Controls.Add(b);

                    int p = Faktorialis(sor) / (Faktorialis(oszlop) * Faktorialis(sor - oszlop));
                    b.Text = p.ToString();
                }
            }
        }
    }
}
