using System;
using CsvHelper;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Formats.Asn1;
using System.Xml;
using System.Data;

namespace M03.UF5._AC3
{
    public static class Helper
    {
        // validar nom Xml
        private static bool IsValidXmlName(string name)
        {
            return Regex.IsMatch(name, @"^[\p{L}\p{Nl}_][\p{L}\p{Nl}\p{Mn}\p{Mc}\p{Nd}\p{Pc}\p{Cf}]*$");
        }

        // Convertir Csv a Xml
        public static void ConvertCsvToXml(string csvPath, string xmlPath)
        {
            const string ConvertOk = "Arxiu Csv convertit a Xml correctament";

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
                    if (!IsValidXmlName(elementName))
                    {
                        elementName = Regex.Replace(elementName, @"[^\w\.-]", "_");
                    }

                    recordElement.Add(new XElement(elementName, kvp.Value));
                }

                root.Add(recordElement);
            }

            var xmlDocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), root);
            xmlDocument.Save(xmlPath);
            Console.WriteLine(ConvertOk);
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
            // Llista d'anys
            var uniqueYears = new List<string>(); // Llista d'anys sense repetir
            var years = new List<string>(); // Llista d'anys ja llegits

            // Llegir xml
            using (var reader = XmlReader.Create(xmlPath))
            {

                while (reader.ReadToFollowing("record"))
                {
                    var consumAigua = new ConsumAigua();

                    var properties = new Dictionary<string, Action<string>>
                {
                    { "Any", value => consumAigua.Any = value },
            };

                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement)
                    {
                        if (reader.NodeType == XmlNodeType.Element && properties.TryGetValue(reader.Name, out var action))
                        {
                            action(Convert.ToString(reader.ReadElementContentAsString()));
                        }
                    }

                    if (consumAigua.Any != null && !years.Contains(consumAigua.Any))
                    {
                        uniqueYears.Add(consumAigua.Any);
                        years.Add(consumAigua.Any);
                    }
                }
            }

            return uniqueYears;
        }

        // Obtenir comarques
        public static List<string> GetComarques(string xmlPath)
        {
            var uniqueComarques = new List<string>(); // Llista de comarques sense repetir

            using (var reader = XmlReader.Create(xmlPath))
            {
                while (reader.ReadToFollowing("record"))
                {
                    reader.ReadToDescendant("Comarca");
                    string comarca = reader.ReadElementContentAsString();

                    if (!uniqueComarques.Contains(comarca))
                    {
                        uniqueComarques.Add(comarca);
                    }
                }
            }

            return uniqueComarques;
        }
    }
}
