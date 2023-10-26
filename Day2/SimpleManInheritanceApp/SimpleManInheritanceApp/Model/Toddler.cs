using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleManInheritanceApp.Model
{
    internal class Toddler:Man
    {
        public override void Play()
        {
            Console.WriteLine("Toddler is playing");
        }
    }
}
