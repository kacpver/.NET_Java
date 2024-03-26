using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("APIkonsolowa"), InternalsVisibleTo("GUI")]

namespace APIkonsolowa
{
    public class APIdownload
    {
        public HttpClient client;
        public async Task GetData()
        {
            string appID = "a98ceda401564003a614eb50f6612207";
            string date = "2022-01-09";
            client = new HttpClient();
            //string call = "https://openexchangerates.org/api/latest.json?app_id=a98ceda401564003a614eb50f6612207";
            string call = $"https://openexchangerates.org/api/historical/{date}.json?app_id={appID}";
            string response = await client.GetStringAsync(call);
            Data data = JsonSerializer.Deserialize<Data>(response);      
            Console.WriteLine(data);
            //Console.WriteLine(response);
        }
    }
}
