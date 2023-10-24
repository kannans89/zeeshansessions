using RectnagleAbstractionApp.Model;

namespace RectnagleAbstractionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;//x expects an integer value
            x = 100;

            Rectangle rectangeSmall;//small is expecting an object
            rectangeSmall = new Rectangle();
            rectangeSmall.width = 10;
            rectangeSmall.height = 20;
            PrintDetails(rectangeSmall);

            Rectangle rectangeBig;//small is expecting an object
            rectangeBig = new Rectangle();
            rectangeBig.width = 100;
            rectangeBig.height = 200;

            PrintDetails(rectangeBig);



        }

        private static void PrintDetails(Rectangle rectangeSmall)
        {
            Console.WriteLine($"small " +
                            $"" +
                            $"widht " +
                            $"is {rectangeSmall.width}" +
                            $" height is {rectangeSmall.height} " +
                            $"and area is {rectangeSmall.CalcuateArea()}");
        }
    }
}