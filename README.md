# M03.UF5. AC3
## IA Consultada
### Chat Gpt Prompts:

Prompt 1:

Quiero insertar los datos de un archivo csv en un dataGrid de windows form en c#, sabes como hacerlo?

Resposta:

using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO; // Asegúrate de agregar una referencia a Microsoft.VisualBasic en tu proyecto

namespace TuNombreProyecto
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnCargarCSV_Click(object sender, EventArgs e)
        {
            // Diálogo para seleccionar un archivo CSV
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Cargar datos CSV en el DataGridView
                CargarDatosCSV(filePath);
            }
        }

        private void CargarDatosCSV(string filePath)
        {
            try
            {
                // Limpiar el DataGridView antes de cargar nuevos datos
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // Utilizar TextFieldParser para leer el archivo CSV
                using (TextFieldParser parser = new TextFieldParser(filePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // Leer la primera línea del archivo CSV para obtener los nombres de las columnas
                    string[] headers = parser.ReadFields();

                    // Agregar columnas al DataGridView basadas en los encabezados del CSV
                    foreach (string header in headers)
                    {
                        dataGridView1.Columns.Add(header, header);
                    }

                    // Leer el resto de las líneas y agregarlas como filas al DataGridView
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        dataGridView1.Rows.Add(fields);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

Prompt 2:

Los datos de Comarca no se ven correctamente en el comboBox, sabes cuál es el error?

Resposta:

Si los datos de la columna "Comarca" no se están mostrando correctamente en el ComboBox, es posible que haya un problema con el formato de los datos o con la forma en que se están agregando al ComboBox. Asegúrate de que los datos se estén leyendo correctamente del archivo CSV y de que se estén agregando al ComboBox de manera adecuada.

Si los datos en la columna "Comarca" contienen espacios en blanco u otros caracteres especiales, es posible que necesites ajustar el delimitador al leer el archivo CSV. Por ejemplo, si los campos están delimitados por comas (,), pero algunos valores de "Comarca" contienen comas como parte del texto, es posible que necesites utilizar un delimitador diferente o un enfoque de análisis más avanzado.
