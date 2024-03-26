using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("APIOkienkowa"), InternalsVisibleTo("GUI")]
namespace APIkonsolowa
{
    
    public class Data
    {
        public int Id { get; set; }
        public int timestamp { get; set; }
        public string @base { get; set; }
        public Rates rates { get; set; }

        public override string ToString()
        {
            return $"Timestamp: {timestamp}\r\nBase: {@base}\r\nRates:\r\n{rates}";
        }

        
    }
    public class Rates
    {

        public double EUR { get; set; }
        public double CZK { get; set; }
        public double PLN { get; set; }
        public double GBP { get; set; }

        public int DataID { get; set; }
        public override string ToString()
        {
            return $"CHF: \r\nEUR: {EUR}\r\nCZK: {CZK}\r\nPLN: {PLN}\r\nGBP: {GBP}\r\n";
        }
    }
}
