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
            string response = await client.GetStringAsync(call);
            Data data = JsonSerializer.Deserialize<Data>(response);
            textBox1.Text = data.ToString();
            //var temp = currencies.Data.FirstOrDefault();
            if (currencies.Data.Any(d => d.timestamp == data.timestamp))
            {
                //textBox3.Text = "istnieje";
                //MessageBox.Show("Obiekt istnieje w bazie danych");
            }
            else
            {
                //textBox3.Text = "nie istnieje";
                currencies.Data.Add(data);
                currencies.SaveChanges();
            }

            //listBox1.DataSource = currencies.Data.ToList<Data>();
            var temp = currencies.Data.FirstOrDefault(d => d.timestamp == data.timestamp);
            //textBox4.Text = temp.rates.EUR.ToString();
            //Konwersja i obliczenie kwoty wyjœciowej
            var value_base = Convert.ToDouble(textBox2.Text);
            var currency_base = comboBox1.SelectedItem;
            var currency_convert = comboBox2.SelectedItem;
            
            string rate_string = "";
            switch (currency_convert)
            {
                case "EUR":
                    rate_string = temp.rates.EUR.ToString(); 
                    break;

                case "GBP":
                    rate_string = temp.rates.GBP.ToString(); 
                    break;

                case "PLN":
                    rate_string = temp.rates.PLN.ToString(); 
                    break;

                case "CZK":
                    rate_string = temp.rates.CZK.ToString(); 
                    break;

                case "CHF":
                    rate_string = temp.rates.CHF.ToString(); 
                    break;

                default:
                    break;
            }
            var rate = Convert.ToDouble(rate_string);
            textBox3.Text = (rate*value_base).ToString("0.00");
             

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            currencies.Data.RemoveRange(currencies.Data);
            currencies.SaveChanges();
        }
    }
}
