using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace APIkonsolowa
{
    public class APIdownload
    {
        public HttpClient client;
        public async Task GetData()
        {
            client = new HttpClient();
            string call = "https://openexchangerates.org/api/latest.json?app_id=a98ceda401564003a614eb50f6612207";
            string response = await client.GetStringAsync(call);
            Data data = JsonSerializer.Deserialize<Data>(response);      
            Console.WriteLine(data);
            //Console.WriteLine(response);
        }
    }
}
