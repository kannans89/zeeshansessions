using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleManInheritanceApp.Model
{
    internal class Boy : Man //extends,(ISA)
    {
        public override void Play()
        {

            Console.WriteLine("Boy plays football");

        }

        public void Eat() {

            Console.WriteLine("Boy is eating burger");
        }

    }
}
