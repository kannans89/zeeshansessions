using CustomerEqualsToStringApp.Model;
using System.Reflection.Metadata;

namespace CustomerEqualsToStringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var c1 = new Customer(1, "Zeeshan", 5);
           
            Console.WriteLine(c1);
            // Console.WriteLine(c1.ToString());
            // Console.WriteLine(c1.GetType());

            var c2 = new Customer(1, "Zeeshan", 5);

            Console.WriteLine( (c1==c2) );//always false
        

            var c3 = c2;
            Console.WriteLine(c3==c2);

            Console.WriteLine(c1.Equals(c2));//want this true


        }
    }
}