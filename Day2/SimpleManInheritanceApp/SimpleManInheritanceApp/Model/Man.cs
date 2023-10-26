using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleManInheritanceApp.Model
{
    internal class Man
    {
        public virtual void Play() {

            Console.WriteLine(  "Man plays cards");

        }

        public void Read() {
            Console.WriteLine( "Man is reading books");
        }
    }
}
