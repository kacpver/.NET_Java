namespace Multiply_matrix
{
    internal static class Program
    {
       
        [STAThread]
        static void Main(string[] args)
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //Thread thread = new Thread(Multiply);
            //thread.Start();

        }
    }
}