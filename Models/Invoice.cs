using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sunniva_Eggen_Appolonia.Models
{
    public class Invoice
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? InvoiceNumber { get; set; } 
        public DateTime InvoiceDate { get; set; }
        public int NumberOfTickets { get; set; }
        public double PriceEurWithoutDiscount { get; set; }
        public double PriceUSDWithoutDiscount { get; set; }
        public double PriceEurWithDiscount { get; set; }
        public double PriceUSDWithDiscount { get; set; }


        public void CreateInvoice(string firstName, string lastName, int numberOfTickets)
        {
            FirstName = firstName;
            LastName = lastName;

            InvoiceDate = DateTime.Now;
            NumberOfTickets = numberOfTickets;  
            Price price = new Price();
            price.GetTicketPrice();

            if (NumberOfTickets<10)
            {
                PriceEurWithoutDiscount = price.PriceInEuro * NumberOfTickets;
                PriceUSDWithoutDiscount = price.PriceInDollar * NumberOfTickets;
                PriceEurWithDiscount = PriceEurWithoutDiscount;
                PriceUSDWithDiscount = PriceUSDWithoutDiscount;
            }
            else
            {
                PriceEurWithoutDiscount = price.PriceInEuro * NumberOfTickets;
                PriceUSDWithoutDiscount = price.PriceInDollar * NumberOfTickets;
                PriceEurWithDiscount = price.PriceInEuro * NumberOfTickets * 0.85;
                PriceUSDWithDiscount = price.PriceInDollar * NumberOfTickets * 0.85;
            }
            

            //Adding the element to xml
            var filename = "Invoice.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var drawsDirectoryFilepath = Path.Combine(currentDirectory, filename);
            //XElement drawsDirectory = XElement.Load(drawsDirectoryFilepath);
            //drawsDirectory.Add(new XElement("Invoice", new XAttribute("id", UID), new XElement("LocalTime", LocalTime),
            //    new XElement("UTCTime", UTCTime), new XElement("Numbers", new XElement("nr1", Numbers[0]),
            //    new XElement("nr2", Numbers[1]), new XElement("nr3", Numbers[2]), new XElement("nr4", Numbers[3]),
            //    new XElement("nr5", Numbers[4]), new XElement("nr6", Numbers[5]), new XElement("nr7", Numbers[6]),
            //    new XElement("nr8", Numbers[7]), new XElement("nr9", Numbers[8])
            //    )));

            //drawsDirectory.Save("Draws.xml");
        }
    }
}
