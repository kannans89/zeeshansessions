using SimpleManInheritanceApp.Model;

namespace SimpleManInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //CaseStudy1();
            // CaseStudy2();

            //CaseStudy3();

            //CaseStudy4();

            CaseStudy5();
           
        }

        private static void CaseStudy5()
        {
            Object box;//(ISA)
            box = 10;
            Console.WriteLine(box.GetType());
            box = "Hello";
            Console.WriteLine(box.GetType());
            box = new Man();
            Console.WriteLine(box.GetType());
            Man m=(Man) box;
            m.Play();
        }

        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Infant());
            AtThePark(new Toddler());
        }

        //polymorphic
        private static void AtThePark(Man man) {
            Console.WriteLine("At the park");
            man.Play();
        }
        private static void CaseStudy3()
        {
            Man x;//x expects object of Man or subclasses of Man
                  // x expects anything isA type of Man

            x = new Boy();
            x.Play();
            x.Read();
           

        }

        private static void CaseStudy2()
        {

            Boy y = new Boy();
            y.Play();
            y.Read();
            y.Eat();
        }

        private static void CaseStudy1()
        {
           Man man = new Man();
           man.Play();
           man.Read();
        

        }
    }
}