using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutoversenyzokMintaZH
{
    public partial class formAddNew : Form
    {
        public Futó ÚjFutó = new();
        public formAddNew()
        {
            InitializeComponent();
        }

        private void formAddNew_Load(object sender, EventArgs e)
        {
            futóBindingSource.DataSource = ÚjFutó;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            formAddNew ÚjFutó = new formAddNew();
        }
    }
}
