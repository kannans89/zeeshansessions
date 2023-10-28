namespace SingleTonAndThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            Thread t1 = new Thread(() =>
            {
                DataService.GetInstance().DoSomething();

            });
            Thread t2 = new Thread(() =>
            {
                DataService.GetInstance().DoSomething();

            });

            t1.Start();
            t2.Start();

        }

        private static void CaseStudy1()
        {
            var sv1 = DataService.GetInstance();
            var sv2 = DataService.GetInstance();

            Console.WriteLine(sv1.GetHashCode());
            Console.WriteLine(sv2.GetHashCode());


            sv1.DoSomething();
            sv2.DoSomething();
        }
    }
}