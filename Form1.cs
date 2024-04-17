using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace M03.UF5._AC3
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();

            // Paths
            const string csvPath = "../../../fitxers/ConsumsAiguaRegio.csv";
            const string xmlPath = "../../../fitxers/ConsumsAiguaRegio.xml";

            // Convertir csv a xml
            Helper.CsvToXml(csvPath, xmlPath);

            // Omplir comboBoxAny
            GetYearsComboBox();

            // Omplir comboBoxComarca
            GetComarquesComboBox();
        }

        /* Carregar a l'inici */
        private void Form1_Load(object sender, EventArgs e)
        {
            //Path
            const string csvPath = "../../../fitxers/ConsumsAiguaRegio.csv";

            // Llegir arxiu csv
            List<ConsumAigua> consumsAigua = ReadInfoCsv(csvPath, dataGridView1);

            // Netejar DataGrid
            CleanDataGrid();

            // Afegir Cap�alera al DataGrid
            GetDataGridHeaders();

            // Afegir columnes al Datagrid
            foreach (var consum in consumsAigua)
            {
                int rowNumber = dataGridView1.Rows.Add();
                
                DataGridViewRow row = dataGridView1.Rows[rowNumber];
                row.Cells["Any"].Value = consum.Any;
                row.Cells["Comarca"].Value = consum.Comarca;
                row.Cells["Poblaci�"].Value = consum.Poblacio;
                row.Cells["Dom�stic xarxa"].Value = consum.Domestic_xarxa;
                row.Cells["Activitats econ�miques i fonts pr�pies"].Value = consum.Activitats_economiques_i_fonts_propies;
                row.Cells["Total"].Value = consum.Total;
                row.Cells["Consum dom�stic per c�pita"].Value = consum.Consum_domestic_per_capita;
            }
        }

        /* Netejar DataGrid */
        private void CleanDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        /* Afegir Cap�alera al DataGrid */
        private void GetDataGridHeaders()
        {
            dataGridView1.Columns.Add("Any", "Any");
            dataGridView1.Columns.Add("Comarca", "Comarca");
            dataGridView1.Columns.Add("Poblaci�", "Poblaci�");
            dataGridView1.Columns.Add("Dom�stic xarxa", "Dom�stic xarxa");
            dataGridView1.Columns.Add("Activitats econ�miques i fonts pr�pies", "Activitats econ�miques i fonts pr�pies");
            dataGridView1.Columns.Add("Total", "Total");
            dataGridView1.Columns.Add("Consum dom�stic per c�pita", "Consum dom�stic per c�pita");
        }

        /* Llegir informaci� de l'arxiu csv */
        private static List<ConsumAigua> ReadInfoCsv(string csvPath, DataGridView dataGridView)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<ConsumAigua>().ToList();
                return records;
            }
        }

        /* Selector Any */
        private void GetYearsComboBox()
        {
            // Path
            const string csvPath = "../../../fitxers/ConsumsAiguaRegio.csv";

            const int YearLimit = 2050;
            List<ConsumAigua> consums = ReadInfoCsv(csvPath, dataGridView1);
            int lastYear = consums.Min(x => x.Any);
            for (int i = lastYear; i <= YearLimit; i++)
            {
                comboBoxAny.Items.Add(i);
            }
        }

        /* Selector Comarca */
        private void GetComarquesComboBox()
        {
            const string xmlPath = "../../../fitxers/ConsumsAiguaRegio.xml";

            List<string> comarques = Helper.GetComarques(xmlPath);
            foreach (var comarca in comarques)
            {
                comboBoxComarca.Items.Add(comarca);
            }
        }

        /* Bot� Netejar */
        private void buttonNetejar_Click(object sender, EventArgs e)
        {
            textBoxPoblacio.Clear();
            textBoxDomesticXarxa.Clear();
            textBoxActivitatsEconomiques.Clear();
            textBoxConsumDomesticPerCapita.Clear();
            textBoxTotal.Clear();
        }

        /* Bot� Guardar */
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Path
            const string csvPath = "../../../fitxers/ConsumsAiguaRegio.csv";

            // Control d'errors
            if (string.IsNullOrEmpty(textBoxPoblacio.Text))
            {
                errorProviderPoblacio.SetError(textBoxPoblacio, "Falta el camp POBLACI�");
            }
            if (string.IsNullOrEmpty(textBoxDomesticXarxa.Text))
            {
                errorProviderDomesticXarxa.SetError(textBoxDomesticXarxa, "Falta el camp DOMESTIC XARXA");
            }
            if (string.IsNullOrEmpty(textBoxActivitatsEconomiques.Text))
            {
                errorProviderActivitatsEconomiques.SetError(textBoxActivitatsEconomiques, "Falta el camp ACTIVITATS ECON�MIQUES I FONTS PR�PIES");
            }
            if (string.IsNullOrEmpty(textBoxTotal.Text))
            {
                errorProviderTotal.SetError(textBoxTotal, "Falta el camp TOTAL");
            }
            if (string.IsNullOrEmpty(textBoxConsumDomesticPerCapita.Text))
            {
                errorProviderConsumDomesticPerCapita.SetError(textBoxConsumDomesticPerCapita, "Falta el camp CONSUM DOM�STIC PER C�PITA");
            }
            if (string.IsNullOrEmpty(comboBoxAny.Text))
            {
                errorProviderAny.SetError(comboBoxAny, "Falta el camp ANY");
            }
            if (string.IsNullOrEmpty(comboBoxComarca.Text))
            {
                errorProviderComarca.SetError(comboBoxComarca, "Falta el camp COMARCA");
            }

            // Guardar dades
            ConsumAigua consum = new ConsumAigua
            {
                Any = int.Parse(comboBoxAny.Text),
                Comarca = comboBoxComarca.Text,
                Poblacio = int.Parse(textBoxPoblacio.Text),
                Domestic_xarxa = int.Parse(textBoxDomesticXarxa.Text),
                Activitats_economiques_i_fonts_propies = int.Parse(textBoxActivitatsEconomiques.Text),
                Total = int.Parse(textBoxTotal.Text),
                Consum_domestic_per_capita = double.Parse(textBoxConsumDomesticPerCapita.Text)
            };
            using (var writer = new StreamWriter(csvPath, append: true))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecord(consum);
            }

            // Recarregar DataGrid
            ReloadDataGrid();
        }

        /* Contingut del DataGrid */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const string csvPath = "../../../fitxers/ConsumsAiguaRegio.csv";
            const int PoblacioLimit = 20000;

            List<ConsumAigua> consumsAigua = ReadInfoCsv(csvPath, dataGridView1);

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int poblacion;
                labelResultPoblacio.Text = int.TryParse(row.Cells["Poblaci�"].Value.ToString(), out poblacion) && poblacion > PoblacioLimit ? "Si" : "No";
                double.TryParse(row.Cells["Dom�stic xarxa"].Value.ToString(), out double domesticXarxa);
                double.TryParse(row.Cells["Poblaci�"].Value.ToString(), out double poblacionDouble);
                double average = poblacionDouble != 0 ? domesticXarxa / poblacionDouble : 0;
                labelResultConsumDomesticMitja.Text = average.ToString();
                int.TryParse(row.Cells["Consum dom�stic/c�pita"].Value.ToString(), out int consumPerCapita);
                bool isBiggestConsumPerCapita = consumPerCapita == consumsAigua.Max(x => x.Consum_domestic_per_capita);
                labelResultConsumMesAlt.Text = isBiggestConsumPerCapita ? "S�" : "No";
                bool lowestConsumDomesticPerCapita = consumPerCapita == consumsAigua.Min(x => x.Consum_domestic_per_capita);
                labelResultConsumMesBaix.Text = lowestConsumDomesticPerCapita ? "Si" : "No";
            }
        }

        /* Actualitzar DataGrid */
        private void ReloadDataGrid()
        {
            const string csvPath = "../../../fitxers/ConsumsAiguaRegio.csv";

            // Netejar DataGrid
            CleanDataGrid();

            // Afegir Cap�alera 
            GetDataGridHeaders();

            List<ConsumAigua> consums = ReadInfoCsv(csvPath, dataGridView1);

            foreach (var consum in consums)
            {
                int rowNumber = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowNumber];

                row.Cells["Any"].Value = consum.Any;
                row.Cells["Comarca"].Value = consum.Comarca;
                row.Cells["Poblaci�"].Value = consum.Poblacio;
                row.Cells["Dom�stic xarxa"].Value = consum.Domestic_xarxa;
                row.Cells["A.E. i fonts pr�pies"].Value = consum.Activitats_economiques_i_fonts_propies;
                row.Cells["Total"].Value = consum.Total;
                row.Cells["Consum dom�stic/c�pita"].Value = consum.Consum_domestic_per_capita;
            }
        }
    }
}
