using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEqualsToStringApp.Model
{
    internal class Customer
    {
      
        public Customer(int id,string name,int ordercount) {
            this.Id = id;
            this.Name = name;
            this.OrderCount = ordercount;

        }
        public int Id { get; private set; }
        public string Name { get; private  set; }

        public int OrderCount { get;private set; }


        public override string ToString()
        {
            return $"id is {this.Id}" +
                $" name is {this.Name} order count is {this.OrderCount} \n Parent: {base.ToString()}";
        }

        public override bool Equals(object? obj)
        {
            return this.ToString() == obj.ToString();
        }
    }
}
