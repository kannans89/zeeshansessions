using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonAndThread
{
    internal class DataService
    {
        private static DataService _bucket = null;
        private static object _mylock = new object();
        private DataService()
        {
            Console.WriteLine("DataServcie created " + this.GetHashCode());
        }

        public static DataService GetInstance()
        {
            lock (_mylock)
            {
                if (_bucket == null)
                    _bucket = new DataService();

                return _bucket;
            }
        }

        public void DoSomething()
        {

            Console.WriteLine("doing data processing.." + this.GetHashCode());
        }
    }
}
