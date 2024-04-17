using System;
using CsvHelper;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Formats.Asn1;
using System.Xml;
using System.Data;
using System.IO;

namespace M03.UF5._AC3
{
    public static class Helper
    {
        // Convertir Csv a Xml
        public static void CsvToXml(string csvPath, string xmlPath)
        {
            var records = new List<Dictionary<string, string>>();

            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    var record = new Dictionary<string, string>();

                    foreach (var header in csv.HeaderRecord)
                    {
                        var clearHeader = header.Replace(" ", "_");
                        record[clearHeader] = csv.GetField(header);
                    }

                    records.Add(record);
                }
            }

            var root = new XElement("data");

            foreach (var record in records)
            {
                var recordElement = new XElement("record");

                foreach (var kvp in record)
                {
                    var elementName = kvp.Key;
                    if (!XmlNameIsValid(elementName))
                    {
                        elementName = Regex.Replace(elementName, @"[^\w\.-]", "_");
                    }

                    recordElement.Add(new XElement(elementName, kvp.Value));
                }

                root.Add(recordElement);
            }

            var xmlDocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), root);
            xmlDocument.Save(xmlPath);
        }

        // Validar nom Xml
        private static bool XmlNameIsValid(string name)
        {
            return Regex.IsMatch(name, @"^[\p{L}\p{Nl}_][\p{L}\p{Nl}\p{Mn}\p{Mc}\p{Nd}\p{Pc}\p{Cf}]*$");
        }

        // Convertir csv a DataGridView
        public static void ConvertCsvToDataGridView(string csvPath, DataGridView dataGridView)
        {
            var records = new List<Dictionary<string, string>>();

            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    var record = new Dictionary<string, string>();

                    foreach (var header in csv.HeaderRecord)
                    {
                        var clearHeader = header.Replace(" ", "_");
                        record[clearHeader] = csv.GetField(header);
                    }

                    records.Add(record);
                }
            }

            // Crear DataTable 
            DataTable dt = new DataTable();

            // Afegir columnes al DataTable
            foreach (var header in records.First().Keys)
            {
                dt.Columns.Add(header);
            }

            // Afegir files al DataTable
            foreach (var record in records)
            {
                var row = dt.NewRow();
                foreach (var kvp in record)
                {
                    row[kvp.Key] = kvp.Value;
                }
                dt.Rows.Add(row);
            }

            // Assignar el DataTable al DataGridView
            dataGridView.DataSource = dt;
        }

        // Obtenir anys
        public static List<string> GetYears(string xmlPath)
        {
            var uniqueYears = new List<string>();

            var xml = XDocument.Load(xmlPath);

            foreach (var element in xml.Root.Elements())
            {
                var year = element.Element("Any")?.Value;
                if (year != null)
                {
                    uniqueYears.Add(year);
                }
            }

            return uniqueYears;
        }

        // Obtenir comarques
        public static List<string> GetComarques(string xmlPath)
        {
            var uniqueComarques = new List<string>();

            var xml = XDocument.Load(xmlPath);

            foreach (var element in xml.Root.Elements())
            {
                var comarca = element.Element("Comarca")?.Value;
                if (comarca != null)
                {
                    uniqueComarques.Add(comarca);
                }
            }

            return uniqueComarques;
        }

        /* Obtenir codi de comarca */
        public static int GetCodiComarca(string comarca)
        {
            const string xmlPath = "../../../fitxers/ConsumsAiguaRegio.xml";
            var xml = XDocument.Load(xmlPath);

            foreach (var element in xml.Root.Elements())
            {
                if (element.Element("Comarca")?.Value == comarca)
                {
                    return int.Parse(element.Element("Codi_comarca")?.Value);
                }
            }

            return -1;
        }

        /* Afegir consums */
        public static void AddConsum(ConsumAigua consum, string path)
        {
            using (var writer = new StreamWriter(path, true))
            using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
            {
                writer.WriteLine();
                csv.WriteRecord(consum);
            }
        }
    }
}
