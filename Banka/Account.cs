using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Account 
    {
        public string Currency;
        public double balance;


        public Client Client;


        public string GetBalance()
        {
            return balance.ToString();
        }
        public void Deposit(double amount)
        {
            if (amount > 10000)
            {
                Console.WriteLine("Vienā reizē nevar iemaksāt vairāk par 10000");
            }
            else
            {
                Console.WriteLine("Jūs iemaksājāt {0}", amount);
                balance += amount;
                Console.WriteLine("Tagadējais atlikums ir {0}", balance);
            }

        }
        public void Withdraw(double amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("nepietiek līdzekļu");
            }
            else if (amount > 500)
            {
                Console.WriteLine("nedrīkst vienā reizē izņemt vairāk par 500");
            }
            else
            {
                Console.WriteLine("Jus iznemat {0} ", amount);
                balance -= amount;
                Console.WriteLine("Jūsu atlikums ir: {0}", balance);
            }
        }
       

        public Account(string currency)
        {
            Currency = currency;
            balance = 0;
        }
       
    }
}
