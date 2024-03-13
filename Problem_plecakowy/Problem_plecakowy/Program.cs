namespace Problem_plecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the number of item:");
             int n = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the seed:");
             int seed = int.Parse(Console.ReadLine());

             Problem problem = new Problem(n, seed);
             Console.WriteLine("List of items:");
             Console.WriteLine(problem);
             problem.Sorting();
             Console.WriteLine(problem);
             Console.WriteLine("Enter the capacity:");
             int capacity = int.Parse(Console.ReadLine());
             Result result = problem.Solve(capacity);
             Console.WriteLine(result);
            /*
            int n = 10;
            int s = 1;
            int c = 25;
            Item item1 = new Item(2, 5, 1);
            Item item2 = new Item(8, 7, 2);
            Item item3 = new Item(5, 4, 3);
            Item item4 = new Item(10, 2, 4);
            Item item5 = new Item(7, 9, 5);
            Item item6 = new Item(6, 1, 6);
            Item item7 = new Item(10, 3, 7);
            Item item8 = new Item(3, 7, 8);
            Item item9 = new Item(7, 5, 9);
            Item item10 = new Item(10, 3, 10);
            List<Item> items = new List<Item>() { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 };
            Problem problem = new Problem(n, s, items);
            problem.Sorting();
            Console.WriteLine(problem);
            Result result = problem.Solve(c);
            Console.WriteLine(result);*/
        }
    }
}