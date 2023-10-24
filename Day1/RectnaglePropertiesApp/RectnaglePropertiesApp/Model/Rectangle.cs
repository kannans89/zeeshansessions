using RectnaglePropertiesApp.Model;
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
        private BorderStyleOptions _borderStyle;



        public BorderStyleOptions BorderSytle { 
         
             get { return _borderStyle; }
            set { _borderStyle = value; }
        }
        
        public int Heigth
        {
            get { return _height; }

            set
            {
                _height = CheckDimension(value);
            }

        }

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = CheckDimension(value);
            }
        }




        private int CheckDimension(int dimension)
        {

            if (dimension > 0 && dimension <= 100)
            {
                return dimension;
            }

            throw new Exception("invalid dimension");
        }
        public int Area
        {
            get
            {
                return _width * _height;
            }
        }

    }
}
