using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzerienuAutomats
{
    class Program
    {
        static void Main(string[] args)
        {
            DzerienuAutomats automats = new DzerienuAutomats();
            
          
               
                while (true)
                {
                    Console.WriteLine("Jums ir pieejamas šādas iespējas - iemaksāt, pirkt, saņemt atlikumu");
                    string koDarīt = Console.ReadLine().ToLower();
                    switch (koDarīt)
                    {
                        case ("iemaksat"):
                            Console.WriteLine("cik vēlaties iemaksāt");
                            float iemaksataisDaudzums = float.Parse(Console.ReadLine());
                            automats.Iemaksat(iemaksataisDaudzums);
                            break;
                        case ("pirkt"):
                            automats.PirktDzerienu();
                            break;
                        case ("sanemt atlikumu"):
                            automats.SanemtAtlikumu();
                            break;
                        default:
                            Console.WriteLine("darbība nav atļauta");
                            break;
                    }
                    /*
                    if (koDarīt == "iemaksat")
                    {
                        Console.WriteLine("cik vēlaties iemaksāt");
                        float iemaksataisDaudzums = float.Parse(Console.ReadLine());
                        automats.Iemaksat(iemaksataisDaudzums);
                        break;

                    }
                    else if (koDarīt == "pirkt")
                    {
                        automats.PirktDzerienu();
                        break;
                    }
                    else if (koDarīt == "sanemt atlikumu")
                    {
                        automats.SanemtAtlikumu();
                        break;
                    }
                    */
                }
                
           
            Console.Read();
        }
        
    }
}
