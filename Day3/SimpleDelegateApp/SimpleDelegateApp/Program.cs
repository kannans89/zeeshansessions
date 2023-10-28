using System.Threading.Channels;

namespace SimpleDelegateApp
{
    internal class Program
    {
        delegate void DPrintMessage(string name);
        static void Main(string[] args)
        {
            //CaseStudy1();

            //CaseStudy2();

            // CaseStudy3();

            //DPrintMessage obj = (n) => Console.WriteLine( n.ToUpper());

            //obj("Lambda - Zeeshan");


            CaseStudy4();
            //Func<string, double> funcPtr = (n) => n.Length;

            //Console.WriteLine(funcPtr("Zeeshan"));

            //Action<string> actionPtr = (n) => Console.WriteLine(n.ToUpper());
            //actionPtr("Zeeshan");

            //Predicate<string> predicationPtr = (n) => n.Length == 7;

            //Console.WriteLine(predicationPtr("Zeeeshan")); ;
        }

        private static void CaseStudy3()
        {
            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBye);

            PrintWizard(delegate (string name)
            {
                Console.WriteLine("Anonymous delegate method called");
                Console.WriteLine(name.ToUpper());

            });

            PrintWizard((n) =>
            {
                Console.WriteLine($"I am arrow fnction {n.ToLower()}");
            });
        }

        static void PrintWizard(DPrintMessage fptr) {
            Console.WriteLine("Doing some printing operation ,will inform");
            Console.WriteLine("operation done");
            fptr("CHAMP completed");

        }
        private static void CaseStudy2()
        {
            DPrintMessage obj1 = new DPrintMessage(PrintHello);
            obj1 += PrintGoodBye;
            obj1 += PrintHello;


            obj1("Koenig");
        }

        private static void CaseStudy1()
        {
            //Account acc1;//acc1 expects ojbect of accunt class or subsclasses of account
            //IEnumerable obj;//obj expects object of a class which implmented IEnumerable
            DPrintMessage obj1;//obj expects a method having signature of the delegate
                               // obj1 = new DPrintMessage(PrintGoodBye);

            obj1 = PrintHello;
            obj1("Zeeshan");
            obj1 = PrintGoodBye;
            obj1("Kannan");
        }

        static void PrintHello(string name) {

            Console.WriteLine($"Hello says {name}");
        }

        static void PrintGoodBye(string name) {
            Console.WriteLine($"Goodby says {name}");
        }

        static void Foo() {
            Console.WriteLine("Inside Foo");
        }

        private static void CaseStudy4()
        {
            //Account acc1;//acc1 expects ojbect of accunt class or subsclasses of account
            //IEnumerable obj;//obj expects object of a class which implmented IEnumerable
            //DPrintMessage obj1;//obj expects a method having signature of the delegate
            // obj1 = new DPrintMessage(PrintGoodBye);

            Action<string> obj1;
            obj1 = PrintHello;
            obj1("Zeeshan");
            obj1 = PrintGoodBye;
            obj1("Kannan");
        }

    }
}