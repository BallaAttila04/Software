using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace databinding
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("european_countries.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var x = csv.GetRecords<CountryData>();
                foreach (var item in x)
                {
                    countryList.Add(item);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (countryDataBindingSource.Current == null) return;

            if (MessageBox.Show("Biztos szeretnéd törölni?", "Törlés megerõsítés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                countryDataBindingSource.RemoveCurrent();
            }
            
        }
    }
}