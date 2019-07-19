using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibioteka2
{
    class Program
    {
        static void Main(string[] args)
        {

            GramatuParvaldnieks gramatuParvaldnieks = new GramatuParvaldnieks();
            Console.WriteLine("Pieejamās grāmatas:");
            gramatuParvaldnieks.SarakstaIzvade();
            while (true)
            {
                Console.WriteLine("Lūdzu izvēlieties darbību:");
                Console.WriteLine("Pieejamās darbības - Atgriezt, Paņemt");
               
                string darbiba = Console.ReadLine();
                if(darbiba == "Atgriezt")
                {
                    Console.Write("ievadiet grāmatas nosaukumu: ");
                    string nosaukums = Console.ReadLine();
                        gramatuParvaldnieks.AtgrieztGramatu(nosaukums);
                } else if(darbiba == "Panemt")
                {
                    Console.Write("ievadiet grāmatas nosaukumu: ");
                    string nosaukums = Console.ReadLine();
                    gramatuParvaldnieks.PanemtGramatu(nosaukums);
                } else if(darbiba == "Stop")
                {
                    break;
                } else
                {
                    Console.WriteLine("Darbība nav atpazīta");
                }
            
            }
            Console.Read();
        }
    }
}
