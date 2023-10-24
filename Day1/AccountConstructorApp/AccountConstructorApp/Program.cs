using AccountConstructorApp.Model;

namespace AccountConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();
          

            var account1 = new Account(name: "Zeeshan", 101);
            var account2 = account1;

            Console.WriteLine( account1.GetHashCode());
            Console.WriteLine(account2.GetHashCode());

            account2.Deposit(1000);

            Console.WriteLine("acc2 balance is "+account2.Balance);
            Console.WriteLine("acc1 balance is " + account1.Balance);
        }

        private static void CaseStudy1()
        {
            var accounts = new Account[3];
            accounts[0] = new Account("Zeeshan", 1001);
            accounts[1] = new Account("kannan", 1002);
            accounts[2] = new Account(name: "Koenig",
                accno: 1003, balance: 3000);

            accounts[2].Deposit(1000);

            foreach (var account in accounts)
            {

                Console.WriteLine($"accno is ," +
                    $"balance: {account.Name} balance is " +
                    $"{account.Balance}");
            }
        }
    }
}