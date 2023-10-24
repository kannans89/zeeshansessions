using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectnagleAbstractionApp.Model
{
    public class Rectangle
    {
        public int width;
        public int height;


        public int CalcuateArea() { 
        
         return width*height;
        }

    }
}
