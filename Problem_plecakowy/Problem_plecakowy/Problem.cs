using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Problem_plecakowy;
[assembly: InternalsVisibleTo("Testy")]
[assembly: InternalsVisibleTo("Aplikacja"), InternalsVisibleTo("GUI")]

namespace Problem_plecakowy
{
    internal class Problem
    {
        Random random; 
        public int num_items;
        public List<Item> items;
        public int seed;
        
        public Problem(int n, int s)
        {
            num_items = n;
            seed = s;
            random = new Random(seed);
            Console.WriteLine(random.Next(10));
            items = new List<Item>();
            for (int i = 0; i < num_items; i++)
            {
                int weight = random.Next(1, 11);
                int value = random.Next(1, 11);
                Item item = new Item(weight, value,i+1);
                items.Add(item);
            }
        }

        public Problem(int n, int s, List<Item> itemstest)
        {
            num_items = n;
            seed = s;
            random = new Random(seed);
            items = itemstest;
        }

        public override string ToString()
        {
            string output = string.Empty;
            foreach (Item x in items)
            {
                output = output + $"No.: {x.index} {x}\r\n";
            }
            return output;
        }

        public void Sorting()
        {
            //items.Sort((a, b) => (a.value / a.weight).CompareTo((b.value / b.weight)));
            items.Sort((a, b) => ((double)b.value / b.weight).CompareTo((double)a.value / a.weight));
        }

        public Result Solve(int c)
        {
            List<int> num = new List<int>();
            int tot_v= 0;
            int tot_w = 0;
            //items.Sort((a, b) => (a.value / a.weight).CompareTo(b.value / b.weight));
            //items.Sort((a, b) => (b.value / b.weight).CompareTo(a.value / a.weight));
            foreach(Item x in items)
            {
                if((tot_w+x.weight)<=c)
                {
                    tot_v += x.value;
                    tot_w += x.weight;
                    num.Add(x.index);
                }
            }
            Result result = new Result(num, tot_v, tot_w);
            return result;
        }
    }
   
}
