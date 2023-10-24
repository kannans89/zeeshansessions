using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountConstructorApp.Model
{
    public class Account
    {
        private string _name;
        private double _balance;
        private int _accno;
        private const double MIN_BALANCE = 1000;
        

        public Account(string name,double balance,int accno) { 
        
             _name = name;
            _balance = balance;
            _accno = accno;
        }

        public Account(string name, int accno)
        {

            _name = name;
            _balance = MIN_BALANCE;
            _accno = accno;
        }

        public void Deposit(double amt) {
            _balance += amt;
        }

        public void Withdraw(double amt) {
            double temp = _balance - amt;
            if (temp >= MIN_BALANCE)
            { 
                _balance = temp;
               return;
            }
            throw new Exception("Insuffiicent funds excpeiton");
        }

        public double Balance { 
        
        get { return _balance; } 
        }

        public string Name { get { return _name; } }

        public int Accno { get { return _accno;} }
    }
}
