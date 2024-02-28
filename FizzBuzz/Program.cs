namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj limit:");
            int uB = Convert.ToInt32(Console.ReadLine());
        
            FizzBuzz fb = new FizzBuzz(uB);
            fb.Display();

        }
    }
}
