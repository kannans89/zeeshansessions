namespace BoxingUnBoxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            object[] boxedItems = new object[3];
            boxedItems[0] = 10.55M;
            boxedItems[1] = 11.55M;
            boxedItems[2] = 12.55M;

            Console.WriteLine(boxedItems);
            Console.WriteLine(boxedItems.GetType());

            decimal sum = 0;
            foreach (object item in boxedItems)
            {
                Console.WriteLine(item.GetType());
                sum += (decimal)item;
            }
            Console.WriteLine(sum);
        }

        private static void CaseStudy1()
        {
            Object box = new Object();
            Console.WriteLine(box.GetType());
            Console.WriteLine(box.GetHashCode());
            box = 10; //value type converting to reference type
            Console.WriteLine(box.GetHashCode());
            Console.WriteLine(box.GetType());

            int result = (int)box * 5; //unboxing
            box = (int)box * 5;//automatic boxing

            Console.WriteLine(result);
        }
    }
}