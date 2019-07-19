using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzerienuAutomats
{
    class DzerienuAutomats
    {
        public float IemaksataSumma;
        

        public DzerienuAutomats()
        {
            IemaksataSumma = 0;
        }
        public float Iemaksat(float summa)
        {
             IemaksataSumma += summa;
            return IemaksataSumma;
        }
        public void PirktDzerienu()
        {
            if(IemaksataSumma >= 0.8f)
            {
                IemaksataSumma -= 0.8f;
                Console.WriteLine("Tavs atlikums {0.0.##}", IemaksataSumma);
                
            } else
            {
                Console.WriteLine("Nepietiek Līdzekļu");   
            }
            
            
        }
        public void SanemtAtlikumu()
            {
                Console.WriteLine("atlikums ir "+   IemaksataSumma);
                IemaksataSumma = 0;
            }
        
    }
}
