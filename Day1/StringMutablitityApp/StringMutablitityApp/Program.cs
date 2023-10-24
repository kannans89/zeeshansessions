using System.Text;

namespace StringMutablitityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            CaseStudy2();

          //  CaseStudy3();
        }

        private static void CaseStudy3()
        {
            StringBuilder userName =new StringBuilder( "Zeeshan");

            userName.Append("London");
            Console.WriteLine(userName.GetHashCode());
            userName.Append(" Developer");
            Console.WriteLine(userName.GetHashCode());
           

            Console.WriteLine(userName);
        }

        private static void CaseStudy2()
        {
            string userName = "Zeeshan";
            Console.WriteLine(userName.GetHashCode());
            userName += "London";
            Console.WriteLine(userName.GetHashCode());
            userName += " Developer";
            Console.WriteLine(userName.GetHashCode());
            userName += " .NET";
            Console.WriteLine(userName.GetHashCode());

            Console.WriteLine(userName);
        }

        private static void CaseStudy1()
        {
            string userName = "Zeeshan";

            userName.ToUpper();

            Console.WriteLine(userName);
        }
    }
}