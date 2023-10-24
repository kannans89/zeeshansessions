using RectangleEncapsulationApp.Model;

namespace RectangleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(10);
            rectangle.SetHeight(20);
            Console.WriteLine($"current width ={rectangle.GetWidth()} " +
                $"current height {rectangle.GetHeight()} area is {rectangle.CalcuateArea()}");

          
        }
    }
}