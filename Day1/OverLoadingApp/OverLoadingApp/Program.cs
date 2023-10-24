namespace OverLoadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInfo(10);
            PrintInfo((int)10d);
            PrintInfo(10M);
            PrintInfo(10f);
            PrintInfo("overloading");

            
        }

        static void PrintInfo(string input) {

            Console.WriteLine($"(1)priting string value {input}");
        }
        static void PrintInfo(double input)
        {
            int x = (int)10M;
            Console.WriteLine(sizeof(double));
            Console.WriteLine($"(2)priting double value {input}");
         
        }
        static void PrintInfo(decimal input)
        {
            Console.WriteLine(sizeof(decimal));
            Console.WriteLine($"(3)priting decimal value {input}");

        }

        static void PrintInfo(float input)
        {
            Console.WriteLine(sizeof(float));
            Console.WriteLine($"(4)priting float value {input}");

        }

        static void PrintInfo(int input)
        {
            Console.WriteLine(sizeof(int));
            Console.WriteLine($"(5)priting int value {input}");

        }
    }
}