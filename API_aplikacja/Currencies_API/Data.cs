using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currencies_API
{
    
    internal class Data
    {
          
            public int Id { get; set; }
            public int? timestamp { get; set; }
            public string? @base { get; set; }
            public Rates? rates { get; set; }
            public string? date_cur { get; set; }
            

            public override string ToString()
            {
                return $"Date: {date_cur}\r\nBase: {@base}\r\nRates: {rates}\r\n";
            }


        
    }
    internal class Rates
    {
        public int Id { get; set; }
        public double EUR { get; set; }
        public double GBP { get; set; }
        public double PLN { get; set; }
        public double CZK { get; set; }
        public double CHF { get; set; }

        public override string ToString()
        {
            return $"\r\nGBP: {GBP}\r\nEUR: {EUR}\r\nPLN: {PLN}\r\nCZK: {CZK}\r\nCHF: {CHF}";
        }
    }
}
