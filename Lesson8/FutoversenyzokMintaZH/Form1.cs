using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace FutoversenyzokMintaZH
{
    public partial class Form1 : Form
    {
        BindingList<Fut�> fut�k = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<Fut�>();

                foreach (var item in t�mb)
                {
                    fut�k.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fut�BindingSource.DataSource = fut�k;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(fut�k);


                    sw.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (fut�BindingSource.Current == null) return;

                if (MessageBox.Show("Biztos szeretn� t�r�lni a kijel�lt sort?", "Meger�s�t�s sz�ks�ges!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fut�BindingSource.RemoveCurrent();
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(ArgumentNullException))
                {
                    MessageBox.Show("Hiba t�rt�nt, nincs kijel�lt sor", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                }
            }
            
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            formAddNew �jSor = new formAddNew();

            if (�jSor.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}