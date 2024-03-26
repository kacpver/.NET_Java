using APIkonsolowa;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace APIOkienkowa
{
    public partial class Form1 : Form
    {
        private Currencies currencies;
        private HttpClient client;
        
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            currencies = new Currencies();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            string currrency_base = comboBox1.SelectedText;
            string currency_convert = comboBox2.SelectedText;
            string appID = "a98ceda401564003a614eb50f6612207";
            string date = "2022-01-09";
            string call = $"https://openexchangerates.org/api/historical/{date}.json?app_id={appID}";
            string response = await client.GetStringAsync(call);
            Data data = JsonSerializer.Deserialize<Data>(response);
            textBox3.AppendText(data.ToString());
            currencies.data.Add(data);
            currencies.SaveChanges();
            //listBox1.DataSource = currencies.data.ToList<Data>();
            

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

       
    }
}
