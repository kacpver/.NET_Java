namespace APIkonsolowa
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            APIdownload t = new APIdownload();
            t.GetData().Wait();
        }
    }
}
