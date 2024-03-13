using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_plecakowy
{
    internal class Result
    {
        public List<int> result;
        public int total_value;
        public int total_weight;

        public Result(List<int> res, int tv, int tw) 
        {
            result = res;
            total_value = tv;
            total_weight = tw;
        }
        public override string ToString()
        {
           string items = string.Join(", ", result);
           return $"Items: {items}\r\nTotal value: {total_value}\r\nTotal weight: {total_weight}";
        }
    }
}
