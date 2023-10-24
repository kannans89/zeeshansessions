using RectangleEncapsulationApp.Model;
using RectnaglePropertiesApp.Model;

namespace RectnaglePropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 100;
            rectangle.Heigth = 20;
            rectangle.BorderSytle = BorderStyleOptions.Dotted;

            Console.WriteLine("area is "+rectangle.Area);


        }
    }
}