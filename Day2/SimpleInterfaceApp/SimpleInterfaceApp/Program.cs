using SimpleInterfaceApp.DataAccess;

namespace SimpleInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoDbOperations(new CustomerDB());
            DoDbOperations(new ProductDB());
        }


        static void DoDbOperations(ICrudable obj) {

            Console.WriteLine("doing db operations");
            obj.Create();
            obj.Read();
            obj.Update();
            obj.Delete();
        }
    }
}