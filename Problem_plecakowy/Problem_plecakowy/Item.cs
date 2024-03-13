using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_plecakowy
{
    internal class Item
    {
        public int weight;
        public int value;
        public int index;
        //public double ratio;

        public Item() 
        {
            weight = 0;
            value = 0;
            index = 0;
            //ratio = 0;
        }

        public Item(int w, int v, int i) 
        { 
            weight = w;
            value = v;
            index = i;
            //ratio = (double)value / weight;
        }

        public override string ToString()
        {
            return $"V: {value} W: {weight}";
        }

       
    }
}
