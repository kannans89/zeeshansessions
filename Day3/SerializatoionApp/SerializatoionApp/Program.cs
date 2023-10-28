using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializatoionApp
{

    
    internal class Program
    {
        static void Main(string[] args)
        {


        

            Customer customer = new Customer();
            customer.Name = "Zeeshan";
            customer.AddOrder(new Order { Description = "books", Id = 1 });

            // SerializeThis(customer);

            DeserializAndPrintCustomer();
        }

        private static void DeserializAndPrintCustomer()
        {
            FileStream fs = new FileStream("customer.bin", FileMode.Open,FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Customer c= (Customer)bf.Deserialize(fs);
            Console.WriteLine(c.Name);
            foreach(var order in c.Orders)
            {

                Console.WriteLine(order.Description);
            }


        }

        private static void SerializeThis(Customer customer)
        {
            FileStream fs = new FileStream("customer.bin",FileMode.Create);
            BinaryFormatter bf =new BinaryFormatter();
            bf.Serialize(fs,customer);
            fs.Close();
           
        }
    }
}