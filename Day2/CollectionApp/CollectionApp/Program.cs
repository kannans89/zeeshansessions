using CollectionApp.Model;
using System.Collections;
using System.Collections.Specialized;

namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            // CaseStudy2();st


            //string[] names = { "A","B","C" };

            //Console.WriteLine(names.GetType());
            //IEnumerable<string> iterateMe = names;

            //IEnumerator<string> iterator = iterateMe.GetEnumerator();
            //while (iterator.MoveNext())
            //{

            //    Console.WriteLine(iterator.Current);
            //}

            //List<string> names = new List<string> { "Ab","C"};
            //Console.WriteLine(names.GetType());
            //IEnumerable<string> iterateMe = names;

            //IEnumerator<string> iterator = iterateMe.GetEnumerator();
            //while (iterator.MoveNext())
            //{

            //    Console.WriteLine(iterator.Current);
            //}

            //var set = new HashSet<string>();

            //set.Add("a");
            //set.Add("b");
            //set.Add("a");

            //var setOfLineItems = new HashSet<LineItem>();
            //var item1 = new LineItem { Name = "Biscuits", Id = 1, Quantiy = 5, UnitPrice = 5 };
            //var item2 = new LineItem { Name = "Biscuits", Id = 1, Quantiy = 5, UnitPrice = 5 };
            //var item3 = new LineItem { Name = "Books", Id = 2, Quantiy = 5, UnitPrice = 5 };
            //setOfLineItems.Add(item1);
            //setOfLineItems.Add(item2);
            //setOfLineItems.Add(item3);


            //Console.WriteLine(setOfLineItems.Count);

            //TODO: something to implemnt here
           Dictionary<string,string>  countryMap= new Dictionary<string,string>(); ;

            countryMap.Add("I", "India");
            countryMap.Add("U", "UnitedKingdom");

            countryMap["I"] = "Indonesia";

            var pair = countryMap.First(p => p.Value == "UnitedKingdom");
            Console.WriteLine(pair.Key);
            

            //foreach(var item in countryMap)
            //{
            //    Console.WriteLine($" {item.Key} = {item.Value} ") ;

            //}



        }

        private static void CaseStudy2()
        {
            var cart = new List<LineItem>();
            cart.Add(new LineItem { Name = "Biscuits", Id = 1, Quantiy = 5, UnitPrice = 5 });
            cart.Add(new LineItem { Name = "Milk", Id = 2, Quantiy = 10, UnitPrice = 5 });
            // cart.Add("kannan");

            double total = 0;

            foreach (var item in cart)
            {

                total += item.Cost;
            }
            Console.WriteLine(total);
        }

        private static void CaseStudy1()
        {
            var cart = new ArrayList();
            cart.Add(new LineItem { Name = "Biscuits", Id = 1, Quantiy = 5, UnitPrice = 5 });
            cart.Add(new LineItem { Name = "Milk", Id = 2, Quantiy = 10, UnitPrice = 5 });
            cart.Add("kannan");

            double total = 0;

            foreach (var item in cart)
            {
                var lineItem = (LineItem)item;
                total += lineItem.Cost;
            }
            Console.WriteLine(total);
        }
    }
}