using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currencies_API
{
    public partial class ChartForm : Form
    {
        private Currencies currencies;
        public ChartForm(string cur_base)
        {
            InitializeComponent();
            currencies = new Currencies();
            List<Rates> sortedRates = currencies.Rates.OrderBy(c => c.Id).ToList<Rates>();
            List<Data> sortedData = currencies.Data.OrderBy(t => t.timestamp).ToList<Data>();
            string rate_base_string = "";
            string rate_convert_string = "";
            var old_rate = 0.0;
            double sum = 0.0;
            foreach (var data in sortedData) 
            {
                
                switch (cur_base)
                {
                    case "EUR":
                        rate_base_string = data.rates.EUR.ToString("0.000000");
                        break;

                    case "GBP":
                        rate_base_string = data.rates.GBP.ToString("0.000000");
                        break;

                    case "PLN":
                        rate_base_string = data.rates.PLN.ToString("0.000000");
                        break;

                    case "CZK":
                        rate_base_string = data.rates.CZK.ToString("0.000000");
                        break;

                    case "CHF":
                        rate_base_string = data.rates.CHF.ToString("0.000000");
                        break;

                    case "USD":
                        rate_base_string = (1.00).ToString("0.000000");
                        break;

                    default:
                        break;
                }
                var rate_base = Convert.ToDouble(rate_base_string);
                
                var downUpEqualsIcons = "";
                if (old_rate == 0.0 || (old_rate == rate_base))
                {
                    downUpEqualsIcons = "";
                }
                else {
                    if (rate_base > old_rate)
                    {
                        downUpEqualsIcons = "+";
                    }
                    else if (rate_base < old_rate)
                    {
                        downUpEqualsIcons = "-";
                    }
                }
                
                listBox1.Items.Add($"Date: {data.date_cur}     USD->{cur_base}: {rate_base_string}   {downUpEqualsIcons}");
                old_rate = rate_base;

                sum += rate_base;
                
            }
            var average = (sum / currencies.Data.Count()).ToString("0.000000");
            listBox1.Items.Add($"Average rate: {average}");
            
        }
    }
}
