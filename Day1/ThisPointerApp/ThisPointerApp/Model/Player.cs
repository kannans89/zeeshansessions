using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisPointerApp.Model
{
    internal class Player
    {
        private int _age;
        private string _name;
        private static int _counter;


        static Player() {
            //_counter = 100;
            Console.WriteLine("Inside static constructor");

        }
        public Player(int _age, string _name) {
            this._age = _age;
            this._name = _name;
            Console.WriteLine("constructor with 2 params");
            _counter += 1;
        }

        public Player(string x):this(18,x) {
            Console.WriteLine("constructor with 1 params");
        }
        public int Age {
            get {  return _age; }
        }

        public string Name { get { return _name; } }

        public Player WhoIsElder(Player other)
        {
           
            return this._age > other.Age ? this : other;
        }

        //public int Counter { 
        
        //get { return _counter; } 
        
        //}

        public static int HeadCount {
            get { 
             return _counter;
            }
        }
    }
}
