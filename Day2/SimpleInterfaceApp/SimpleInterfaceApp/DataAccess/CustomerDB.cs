using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    internal class CustomerDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer created");
        }

        public void Delete()
        {
            Console.WriteLine("Customer deleted");
        }

        public void Read()
        {
            Console.WriteLine("Customer reading");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated");
        }
    }
}
