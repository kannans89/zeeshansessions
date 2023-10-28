using AccountEventLib;
using System.Threading.Channels;

namespace SubscriberApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var account = new Account(accno: 101, name: "kannan");
            
            account.Deposit(100);
            account.OnBalaceChnaged += (acc) => Console.WriteLine("sms sent to " + acc.Name);
            account.OnBalaceChnaged += (acc) => Console.WriteLine("email sent to " + acc.Name);
        }

       
    }
}