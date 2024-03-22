using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIkonsolowa
{
    
    internal class Data
    {
        public int Id {  get; set; }
        public required int timestamp { get; set; }
        public string @base { get; set; }
        public Dictionary<string, decimal> rates { get; set; }

        public override string ToString()
        {
            return $"Timestamp: {timestamp}\nBase: {@base}\nRates:\n{RatesToString()}";
        }

        private string RatesToString()
        {

            string ratesString = "";
            foreach (var rate in rates)
            {
                ratesString += $"{rate.Key}: {rate.Value}\n";
            }
            return ratesString;
        }
    }
}
