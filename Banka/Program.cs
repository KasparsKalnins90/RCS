using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Account a = new Account("EUR");

            a.Client = new Client("Jānis", "Briedis", "V");
            Console.WriteLine("Atlikums: {0}", a.GetBalance());
            a.Deposit(150.0); // m burts parāda, ka tas ir decimal!!!!
            a.Withdraw(105.0);
            Console.WriteLine("Atlikums: {0}", a.GetBalance());
            Console.Read();

        }
    }
}
