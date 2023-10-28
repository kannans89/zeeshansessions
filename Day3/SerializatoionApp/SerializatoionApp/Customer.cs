using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializatoionApp
{

    [Serializable]
    internal class Customer
    {

        public string Name { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();

        public void AddOrder(Order o) { 
         Orders.Add(o);
        }

    }
}
