using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    internal class LineItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Quantiy { get; set; }

        public double UnitPrice { get; set; }

        public double Cost {
            get {
                return UnitPrice * Quantiy;
            }
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override bool Equals(object? obj)
        {
            LineItem other = (LineItem)obj ;
            return this.Id == other.Id;
        }
    }
}
