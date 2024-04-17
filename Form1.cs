using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace M03.UF5._AC3
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Carregar al'inici
        private void Form1_Load(object sender, EventArgs e)
        {
            // Paths
            const string csvPath = "../../../fitxers/ConsumsAiguaRegio.csv";
            const string xmlPath = "../../../fitxers/ConsumsAiguaRegio.xml";

            // Convertir csv a xml i mostrar si s'ha convertit correctament
            Helper.ConvertCsvToXml(csvPath, xmlPath);

            // Csv a datagrid
            Helper.ConvertCsvToDataGridView(csvPath, dataGridView1);
        }

        // Selector Any
        private void comboBoxAny_Click(object sender, EventArgs e)
        {
            const string xmlPath = "../../../fitxers/ConsumsAiguaRegio.xml";

            // Obtenir anys
            var years = Helper.GetYears(xmlPath);

            // Netejar
            comboBoxAny.Items.Clear();

            // Mostrar anys al selector
            foreach (var year in years)
            {
                comboBoxAny.Items.Add(year);
            }
        }

        // Selector Comarca
        private void comboBoxComarca_Click(object sender, EventArgs e)
        {
            const string xmlPath = "../../../fitxers/ConsumsAiguaRegio.xml";

            // Obtenir anys
            var comarques = Helper.GetComarques(xmlPath);

            // Netejar
            comboBoxComarca.Items.Clear();

            // Mostrar anys al selector
            foreach (var comarca in comarques)
            {
                comboBoxComarca.Items.Add(comarca);
            }

        }

        // Botó Netejar
        private void buttonNetejar_Click(object sender, EventArgs e)
        {           
            textBoxPoblacio.Clear();
            textBoxDomesticXarxa.Clear();
            textBoxActivitatsEconomiques.Clear();
            textBoxConsumDomesticPerCapita.Clear();
            textBoxTotal.Clear();
        }
    }
}
