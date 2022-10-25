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

            var filename = "Invoice.txt";
            string textToWrite = $"FirstName: {FirstName}, LastName: {LastName}, Invoice date: {InvoiceDate}, Number of tickets bought: {NumberOfTickets}, " +
                $"Price before discount: {PriceEurWithoutDiscount} EUR, Price after discount: {PriceEurWithDiscount}";
            FileStream outputstream=new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw=new StreamWriter(outputstream);
            sw.Write(textToWrite);
            sw.Close();
        }
    }
}
