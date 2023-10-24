using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    public class Rectangle
    {
        private int _width;
        private int _height;


        public int GetWidth() {
            return _width;
        }

        public int GetHeight()
        {
            return _height;

        }
        public void SetWidth(int width) {
           
             _width = CheckDimension(width);
            
        }

        public void SetHeight(int height)
        {

                _height = CheckDimension(height);
          
        }

        private int CheckDimension(int dimension) {

            if (dimension > 0 && dimension <= 100)
            {
                return dimension;
            }

            throw new Exception("invalid dimension");
        }
        public int CalcuateArea()
        {

            return _width * _height;
        }

    }
}
