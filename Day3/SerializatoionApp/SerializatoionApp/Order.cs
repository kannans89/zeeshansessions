using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializatoionApp
{
    [Serializable]
    internal class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }

    }
}
