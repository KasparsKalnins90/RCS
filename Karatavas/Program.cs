using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Program
    {
        static void Main(string[] args)
        {
            Karatavas spele = new Karatavas();
            string burts;
            spele.SaktSpeli();
            Console.WriteLine("uzmini vārdu - {0}", spele.Vards());
            while (!spele.IrAtminets())
            {
                Console.Write("ievadi burtu: ");
                burts = Console.ReadLine();

                if (spele.Minet(burts))
                {
                    Console.WriteLine(spele.Vards());
                }
                else Console.WriteLine("burts nav šajā vārdā");
            }

            Console.WriteLine("Vārds veiksmīgi atminēts!");
            Console.Read();
            
        }
    }
}
