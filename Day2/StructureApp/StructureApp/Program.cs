namespace StructureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            int x = 100;

            Console.WriteLine( x.GetHashCode());

            x = 200;
            Console.WriteLine(x.GetHashCode());

            string y = "abc";
            Console.WriteLine(y.GetHashCode());
            y = "pqr";
            Console.WriteLine(y.GetHashCode());
        }

        private static void CaseStudy1()
        {
            Point p1 = new Point();
            p1.x = 10;
            p1.y = 20;


            Point p2 = p1;
            p2.x = 100;



            PrintDetails(p1, "P1");
            PrintDetails(p2, "P2");
        }

        private static void PrintDetails(Point point, string description)
        {
            Console.WriteLine( description);
            Console.WriteLine($"x ={point.x} y={point.y}");
        }
    }
}