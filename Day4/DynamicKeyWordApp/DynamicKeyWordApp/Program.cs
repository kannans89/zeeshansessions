namespace DynamicKeyWordApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dynamic x;

            //x = "hello";

            //int y = x;


            dynamic customer = new { 
              FirstName = "Sachin",
              LastName = "Tendulkar"
            };

            string fullName =  customer.FirstName + " " + customer.LastName;

            Console.WriteLine(fullName);



        }
    }
}