using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamoloGomb
{
    internal class SzámolóGomb : Button
    {
        int szám;
        public SzámolóGomb()
        {
            Height = 40;
            Width = 40;
            Click += SzámolóGomb_Click;
        }

        private void SzámolóGomb_Click(object sender, EventArgs e)
        {
            szám++;
            if (szám == 6)
            {
                szám = 1;
            }
            Text = szám.ToString();
        }
    }
}
