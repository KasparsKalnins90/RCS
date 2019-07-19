using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibioteka2
{
    public class GramatuParvaldnieks
    {
        public List<Gramata> Gramatas;

        public GramatuParvaldnieks()
        {
            Gramatas = new List<Gramata>();
            Gramatas.Add(new Gramata() { Nosaukums = "The Illiad", Skaits = 3 });
            Gramatas.Add(new Gramata() { Nosaukums = "Moby Dick", Skaits = 2 });
        }

        public Gramata PanemtGramatu(string nosaukums)
        {
            Gramata gramata = null;
            foreach (Gramata g in Gramatas)
            {
                if (g.Nosaukums.Equals(nosaukums, StringComparison.OrdinalIgnoreCase))
                {
                    gramata = g;
                    
                    break;
                }

                // otrs variants  - - Gramata gramata = Gramatas.Find(g => g.Nosaukums.Equals(nosaukums, StringComparison.OrdinalIgnoreCase));
            }
            if (gramata == null)
            {
                Console.WriteLine("Šāda grāmata nav atrasta!");
                ;

            }
            else
            {
             if(gramata.Skaits == 0)
                {
                    Console.WriteLine("Šī grāmata vairs nav pieejama");
                    
                }
                else
                {
                    gramata.Skaits--;
                    SarakstaIzvade();
                    return gramata;
                }
            }
            
            return null;

        }
        public void AtgrieztGramatu(string nosaukums)
        {
            Gramata gramata = null;

            foreach (Gramata g in Gramatas)
            {
                if (g.Nosaukums.Equals(nosaukums, StringComparison.OrdinalIgnoreCase))
                {
                    gramata.Skaits++;
                    
                    break;
                }
                // otrs variants  - - Gramata gramata = Gramatas.Find(g => g.Nosaukums.Equals(nosaukums, StringComparison.OrdinalIgnoreCase));
            }
            if (gramata == null)
            {
                Console.WriteLine("Grāmata pievienota bibliotekai");
                Gramatas.Add(new Gramata() { Nosaukums = nosaukums, Skaits = 1 });
                
            }
            SarakstaIzvade();
        }

        public void SarakstaIzvade()
        {
            foreach(Gramata g in Gramatas)
            {
                Console.WriteLine("Pieejami {0} grāmatas {1} eksemplāri", g.Skaits, g.Nosaukums);
            }
        }
    }
}
