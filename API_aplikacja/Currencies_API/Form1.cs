using System.Text.Json;
using System.Text.Json.Nodes;
using System.Linq;

namespace Currencies_API
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        private Currencies currencies;

        public Form1()
        {

            InitializeComponent();
            client = new HttpClient();
            currencies = new Currencies();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            string appID = "a98ceda401564003a614eb50f6612207";
            string selectdate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string date = selectdate;
            string call = $"https://openexchangerates.org/api/historical/{date}.json?app_id={appID}";
            //string response = await client.GetStringAsync(call);
            Data data = new Data();
            //Data data = JsonSerializer.Deserialize<Data>(response);
            //data.date_cur = date;
            //textBox1.Text = data.ToString();
            //var temp = currencies.Data.FirstOrDefault();
            
            if (currencies.data.Any(d => d.date_cur == selectdate))
            {
                //textBox3.Text = "istnieje";
                MessageBox.Show("Obiekt istnieje w bazie danych");
            }
            else
            {
                string response = await client.GetStringAsync(call);
                data = JsonSerializer.Deserialize<Data>(response);
                data.date_cur = date;
                textBox1.Text = data.ToString();
                //textBox3.Text = "nie istnieje";
                currencies.data.Add(data);
                currencies.SaveChanges();
            }

            //listBox1.DataSource = currencies.Data.ToList<Data>();
            var temp = currencies.data.FirstOrDefault(d => d.date_cur == selectdate);
            //textBox4.Text = temp.rates.EUR.ToString();
            //Konwersja i obliczenie kwoty wyjœciowej
            var value_base = Convert.ToDouble(textBox2.Text);
            var currency_base = comboBox1.SelectedItem;
            var currency_convert = comboBox2.SelectedItem;

            string rate_base_string = "";
            switch (currency_base)
            {
                case "EUR":
                    rate_base_string = temp.rates.EUR.ToString();
                    break;

                case "GBP":
                    rate_base_string = temp.rates.GBP.ToString();
                    break;

                case "PLN":
                    rate_base_string = temp.rates.PLN.ToString();
                    break;

                case "CZK":
                    rate_base_string = temp.rates.CZK.ToString();
                    break;

                case "CHF":
                    rate_base_string = temp.rates.CHF.ToString();
                    break;

                case "USD":
                    rate_base_string = (1.00).ToString();
                    break;
                default:
                    break;
            }

            string rate_convert_string = "";
            switch (currency_convert)
            {
                case "EUR":
                    rate_convert_string = temp.rates.EUR.ToString(); 
                    break;

                case "GBP":
                    rate_convert_string = temp.rates.GBP.ToString(); 
                    break;

                case "PLN":
                    rate_convert_string = temp.rates.PLN.ToString(); 
                    break;

                case "CZK":
                    rate_convert_string = temp.rates.CZK.ToString(); 
                    break;

                case "CHF":
                    rate_convert_string = temp.rates.CHF.ToString(); 
                    break;

                case "USD":
                    rate_convert_string = (1.00).ToString();
                    break;
                default:
                    break;
            }
            if (rate_base_string == "USD")
            {
                var rate = Convert.ToDouble(rate_convert_string);
                textBox3.Text = (rate * value_base).ToString("0.00");
            }
            else
            {
                var rate_base = Convert.ToDouble(rate_base_string);
                var rate_convert = Convert.ToDouble(rate_convert_string);
                textBox3.Text = (value_base*(rate_convert/rate_base)).ToString("0.00");
            }
             

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currencies.data.RemoveRange(currencies.data);
            currencies.SaveChanges();
        }
    }
}
