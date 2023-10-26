using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    internal class ProductDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("product created");
        }

        public void Delete()
        {
            Console.WriteLine("product deleted");
        }

        public void Read()
        {
            Console.WriteLine("product read");
        }

        public void Update()
        {
            Console.WriteLine("product deleted");
        }
    }
}
