using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Sunniva_Eggen_Appolonia.Models
{
    public class Price
    {
        public double PriceInEuro { get; set; } = 5.0;
        public double PriceInDollar { get; set; }
        public double PriceInSwissFranc { get; set; }
        public double PriceInYen { get; set; }

        public double EurToDollar { get; set; }
        public double EurToSwissFranc { get; set; }
        public double EurToYen { get; set; } 

        public void GetCurrency()
        {
            string uri = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml";
            XDocument xDoc = XDocument.Load(uri);
            XmlDocument xmlDoc = new XmlDocument();

            //XDocument -> XmlDocument
            using (var xmlReader = xDoc.CreateReader())
            {
                xmlDoc.Load(xmlReader);
            }

            var env = xmlDoc["gesmes:Envelope"];
            var cube1 = env["Cube"];
            var cube2 = cube1["Cube"];

            var attList = new List<MapXmlCurrency>();

            foreach (XmlElement child in cube2.ChildNodes)
            {
                string? cur = child.Attributes["currency"]?.Value.ToString();
                string? rate = child.Attributes["rate"]?.Value?.ToString();

                attList.Add(new MapXmlCurrency(cur, rate));
            }

            EurToDollar = Convert.ToDouble(attList[0].Rate.Replace(".", ","));
            EurToYen = Convert.ToDouble(attList[1].Rate.Replace(".", ","));
            EurToSwissFranc = Convert.ToDouble(attList[10].Rate.Replace(".", ","));
        }

        public void GetTicketPrice()
        {
            GetCurrency();
            PriceInDollar = PriceInEuro * EurToDollar;
            PriceInSwissFranc = PriceInEuro * EurToSwissFranc;
            PriceInYen = PriceInEuro * EurToYen;
        }

        public string CreateFile()
        {
            string textToWrite = "";
            var filename = "Prices.txt";
            textToWrite = $"Exchange rate EUR to USD: {EurToDollar} \n" +
                $"Exchange rate EUR to JPY: {EurToYen}\n" +
                $"Exchange rate EUR to CHF: {EurToSwissFranc}\r\n" +
                $"Price of a ticket in Euro: {PriceInEuro}EUR\r\n" +
                $"Price of a ticket in Dollar: {PriceInDollar}USD\r\n" +
                $"Price of a ticket in Yen: {PriceInYen}JPY\r\n" +
                $"Price of a ticket in Swiss Franc: {PriceInSwissFranc}CHF";
            FileStream outputstream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(outputstream);
            sw.Write(textToWrite);
            sw.Close();
            return textToWrite;
        }
    }
}
