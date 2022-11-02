using System;
using System.IO;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class FormSupermarket : Form
    {
        public FormSupermarket()
        {
            InitializeComponent();
        }

        private void FormSupermarket_Load(object sender, EventArgs e)
        {

        }

        private void BtnAnalysis_Click(object sender, EventArgs e)
        {
            int[,] quantity = new int[4, 13];
            string[] months = new string[13];
            int[] years = new int[4];
            double[] prices = new double[4];

            int[] yearTotal = new int[4];
            int[] monthTotal = new int[13];
            double[] sales = new double[4];

            string path = Application.StartupPath + @"\supermarket.txt";

            StreamReader streamReader = new StreamReader(path);


            //Load data from the file for quantity, years, month names and prices
            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 12; c++)
                {
                    quantity[r, c] = Convert.ToInt32(streamReader.ReadLine());
                }
            }

            for (int i = 1; i <= 3; i++)
            {
                years[i] = Convert.ToInt32(streamReader.ReadLine());
            }

            for (int i = 1; i <= 12; i++)
            {
                months[i] = streamReader.ReadLine();
            }

            for (int i = 1; i <= 3; i++)
            {
                prices[i] = Convert.ToDouble(streamReader.ReadLine());
            }

            streamReader.Close();


            //Display data in a table format
            for (int i = 1; i <= 12; i++)
            {
                TxtText.Text += "       " + months[i];
            }
            TxtText.Text += Environment.NewLine;

            for (int r = 1; r <= 3; r++)
            {
                TxtText.Text += years[r].ToString();
                for (int c = 1; c <= 12; c++)
                {
                    TxtText.Text += "   " + quantity[r, c] + "      ";
                }
                TxtText.Text += Environment.NewLine;
            }
            TxtText.Text += Environment.NewLine;


            //Calculate total sales quantity per year using array counter
            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 12; c++)
                {
                    yearTotal[r] += quantity[r, c];
                }
            }

            //Display total sales quantity per year
            TxtText.Text += "Year \t Total" + Environment.NewLine; ;
            for (int i = 1; i <= 3; i++)
            {
                TxtText.Text += years[i] + "\t " + yearTotal[i] + Environment.NewLine; ;
            }
            TxtText.Text += Environment.NewLine;


            //Calculate total sales quantity for each month
            for (int c = 1; c <= 12; c++)
            {
                for (int r = 1; r <= 3; r++)
                {
                    monthTotal[c] += quantity[r, c];
                }
            }
            //Display total sales quantity per months
            TxtText.Text += "Month \t Total" + Environment.NewLine;
            for (int i = 1; i <= 12; i++)
            {
                TxtText.Text += months[i] + "\t " + monthTotal[i] + Environment.NewLine; ;
            }
            TxtText.Text += Environment.NewLine;


            //Find year and month with greatest sales quantity
            int greatest = quantity[1, 1];
            int posR = 0;
            int posC = 0;
            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 12; c++)
                {
                    if (quantity[r, c] > greatest)
                    {
                        greatest = quantity[r, c];
                        posR = r;
                        posC = c;
                    }
                }
            }

            //Display month with greates sales quantity
            TxtText.Text += "Greatest sales were at: " + Environment.NewLine;
            TxtText.Text += "Year: " + years[posR] + Environment.NewLine;
            TxtText.Text += "Month: " + months[posC] + Environment.NewLine;
            TxtText.Text += "Sales: " + quantity[posR, posC] + Environment.NewLine;
            TxtText.Text += Environment.NewLine;

            //Calculate total sales value per year
            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 12; c++)
                {
                    sales[r] += quantity[r, c] * prices[r];
                }
            }
            //Display total sales
            TxtText.Text += "Year \t Total sales" + Environment.NewLine;
            for (int i = 1; i <= 3; i++)
            {
                TxtText.Text += years[i] + "\t " + sales[i] + Environment.NewLine;
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
