using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp.Model
{
    internal class ParentV1
    {

        public ParentV1() {
            Console.WriteLine( "inside parentV1");
        }

        protected void m1()
        {
            Console.WriteLine("inside parentV1");
        }
    }
}
