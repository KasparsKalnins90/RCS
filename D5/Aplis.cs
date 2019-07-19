using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Aplis
    {
        public double Radiuss;
        public string Krasa;

        public Aplis(int radiuss, string krasa)
        {
            Radiuss = radiuss;
            Krasa = krasa;

        }

        public double Laukums()
        {
            return Math.PI * Radiuss * Radiuss;
        }
        public string KrasasNosaukums()
        {
            return Krasa;
            
        }
        public double Perimetrs()
        {
            return 2 * Math.PI * Radiuss;
        }
    }
    
}
