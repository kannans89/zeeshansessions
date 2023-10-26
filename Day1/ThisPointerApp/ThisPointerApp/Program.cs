using ThisPointerApp.Model;

namespace ThisPointerApp
{
    internal class Program
    {
        

        
        static void Main(string[] args)
        {
            // CaseStudy1();

            // PrintDetails(new Player("kannan"));//Anonymous object


            var p1 = new Player("A");
            //Console.WriteLine(p1.Counter);
            Console.WriteLine(Player.HeadCount);

            var p2 = new Player("B");
            //  Console.WriteLine(p1.Counter);
            //  Console.WriteLine(Player.GetHeadCount());
            Console.WriteLine(Player.HeadCount);

            var p3 = new Player("C");
            Console.WriteLine(Player.HeadCount);

            //  Console.WriteLine(p1.Counter);
            // Console.WriteLine(Player.GetHeadCount());
        }

        private static void PrintDetails(Player player)
        {
            Console.WriteLine("name is "+player.Name);
            Console.WriteLine("age is " + player.Age);
        }

        private static void CaseStudy1()
        {
            var p1 = new Player(20, "Sachin");

            var p2 = new Player(30, "Vicky");

            var elderPlayer = p1.WhoIsElder(p2);

            Console.WriteLine("name and age of elder player");


            Console.WriteLine($"name is {p1.Name} age is {p1.Age}");
        }
    }
}