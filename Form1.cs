using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Serialization;
using Sunniva_Eggen_Appolonia.Models;

namespace Sunniva_Eggen_Appolonia
{
    public partial class Form1 : Form
    {
        public List<Draw> ListOfDraws = new List<Draw>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //Everytime the user clicks ont the button, a new Draw object is created. Its method AddDraw(int uid) is called upon
            Draw draw = new Draw();
            draw.AddDraw();

            txtDraw.AppendText(draw.Numbers[0].ToString() +"\t"+ (draw.Numbers[1].ToString()) + "\t" + (draw.Numbers[2].ToString()) + "\t" +
                (draw.Numbers[3].ToString()) + "\t" + (draw.Numbers[4].ToString()) + "\t" + (draw.Numbers[5].ToString()) + "\t" + 
                (draw.Numbers[6].ToString()) + "\t" + (draw.Numbers[7].ToString()) + "\t" + (draw.Numbers[8].ToString()));

            //The new Draw object is added to the list of Draws
            ListOfDraws.Add(draw);

            int numberOfOnes=0;
            int numberOfTwos = 0;
            int numberOfThrees = 0;
            int numberOfFours = 0;
            int numberOfFives = 0;
            int numberOfSixes = 0;
            int numberOfSevens = 0;
            int numberOfEights = 0;
            int numberOfNines = 0;
            int numberOfTens = 0;
            int numberOfElevens = 0;
            int numberOfTwelves = 0;
            int numberOfThirteens = 0;
            int numberOfFourteens = 0;
            int numberOfFifteens = 0;
            int numberOfSixteens = 0;
            int numberOfSeventeens = 0;
            int numberOfEighteens = 0;
            int numberOfNineteens = 0;
            int numberOfTwenties = 0;

            foreach (Draw d in ListOfDraws)
            {
                foreach (int number in d.Numbers)
                {
                    
                    switch (number)
                    {
                        case 1:
                            numberOfOnes++;
                            break;
                        case 2:
                            numberOfTwos++;
                            break;
                        case 3:
                            numberOfThrees++;
                            break;
                        case 4:
                            numberOfFours++;
                            break;
                        case 5:
                            numberOfFives++;
                            break;
                        case 6:
                            numberOfSixes++;
                            break;
                        case 7:
                            numberOfSevens++;
                            break;
                        case 8:
                            numberOfEights++;
                            break;
                        case 9:
                            numberOfNines++;
                            break;
                        case 10:
                            numberOfTens++;
                            break;
                        case 11:
                            numberOfElevens++;
                            break;
                        case 12:
                            numberOfTwelves++;
                            break;
                        case 13:
                            numberOfThirteens++;
                            break;
                        case 14:
                            numberOfFourteens++;
                            break;
                        case 15:
                            numberOfFifteens++;
                            break;
                        case 16:
                            numberOfSixteens++;
                            break;
                        case 17:
                            numberOfSeventeens++;
                            break;
                        case 18:
                            numberOfEighteens++;
                            break;
                        case 19:
                            numberOfNineteens++;
                            break;
                        case 20:
                            numberOfTwenties++;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            Price price = new Price();
            price.GetTicketPrice();
            string textToWrite = price.CreateFile();
            txtPrices.Text = textToWrite;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int numberOfTickets = 0;
            try
            {
                numberOfTickets = Convert.ToInt32(txtNumberOfTickets.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Type in valid number");
                throw;
            }
            string invoiceNumber=txtInvoiceNumber.Text;
            Invoice invoice = new Invoice();
            invoice.CreateInvoice(firstName, lastName,numberOfTickets, invoiceNumber);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            stats.DeserializeXMLFile();
            stats.MapClasses();
            stats.CountRepartitionOfNumbers();
            stats.CalculatePercentages();

            txtStatistics.Clear();

            for (int i = 0; i < stats.ListOfPercentages.Count; i++)
            {
                txtStatistics.AppendText((i+1).ToString() + "\t" + (stats.ListOfDrawsPerNumber[i].ToString() + "\t"+Math.Round(stats.ListOfPercentages[i], 2).ToString() + "\r\n"));
            }


            //Imported NuGet package as charts class is no longer available in .NET 6.0. 
            double[] dataX=new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            double[] dataY = new double[20];

            for (int i = 0; i < stats.ListOfDrawsPerNumber.Count; i++)
            {
                dataY[i] = stats.ListOfDrawsPerNumber[i];
            }

            formsPlot1.Plot.AddBar(dataY, dataX);
            formsPlot1.Refresh();
        }
    }
        
        public class Draws
        {
            public List<Draws> ListOfDraws=new List<Draws>();
        }
    }
