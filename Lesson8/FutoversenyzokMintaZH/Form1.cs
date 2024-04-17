using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace FutoversenyzokMintaZH
{
    public partial class Form1 : Form
    {
        BindingList<Futó> futók = new();
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
                var tömb = csv.GetRecords<Futó>();

                foreach (var item in tömb)
                {
                    futók.Add(item);
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
            futóBindingSource.DataSource = futók;
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
                    csv.WriteRecords(futók);


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
                if (futóBindingSource.Current == null) return;

                if (MessageBox.Show("Biztos szeretné törölni a kijelölt sort?", "Megerõsítés szükséges!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    futóBindingSource.RemoveCurrent();
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(ArgumentNullException))
                {
                    MessageBox.Show("Hiba történt, nincs kijelölt sor", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                }
            }
            
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            formAddNew ÚjSor = new formAddNew();

            if (ÚjSor.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}