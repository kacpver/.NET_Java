using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIkonsolowa
{
    internal class Latest
    {
        //public string disclaimer {  get; set; }
        //public string license { get; set; }
        public int timestamp { get; set; }
        public string @base { get; set; }
        public Dictionary<string, decimal> rates { get; set; }

        //public override string ToString()
        //{
        //    return $"Disclaimer: {disclaimer}\nLicense: {license}\nTimestamp: {timestamp}\nBase: {@base}\nRates:\n{RatesToString()}";
        //}
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
