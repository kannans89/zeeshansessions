namespace CommandLineArgsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            if (args.Length == 0)
            {
                Console.WriteLine("Hello, World!");
                return;
            }

            foreach (string arg in args)
            {
                Console.WriteLine($" Hello {arg} ");
            }
        }
    }
}