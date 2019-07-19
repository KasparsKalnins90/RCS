using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Karatavas
    {
        public string MinamaisVards { get; set; }
        public string[] AtminetaisVards { get; set; }
        public string[] Vardnica { get; set; }
        public Karatavas()
        {
            Vardnica = new[]
            {
                "ZIEPES",
                "AUKSTUMS",
                "PAVASARIS"
            };
        }

        public void SaktSpeli()
        {

            Random random = new Random();
            MinamaisVards = Vardnica[random.Next(Vardnica.Length)];
            AtminetaisVards = new string[MinamaisVards.Length];
            for(int i = 0; i < AtminetaisVards.Length; i++)
            {
                AtminetaisVards[i] = "*";
            }
        }
        public bool IrAtminets()
        {
            foreach(string simbols in AtminetaisVards)
            {
                if (simbols == "*")
                {
                    return false;
                }
                    
            }
            return true;

            // 2. variants return !AtminetaisVards.Contains("*");
        }


        public bool Minet(string burts)
        {
            burts = burts.ToUpper();
            if (!MinamaisVards.Contains(burts))
            {
                return false;
            }

            // int pozicija = MinamaisVards.IndexOf(burts);
            // AtminetaisVards[pozicija] = burts;
            for (int pozicija = 0; pozicija < MinamaisVards.Length; pozicija++)
            {
                if (MinamaisVards[pozicija].ToString() == burts)
                {
                    AtminetaisVards[pozicija] = burts;
                    
                }

                
            }
            return true;
        }

        public string Vards()
        {
            return String.Join(" ", AtminetaisVards);
        }
    }
    
}
