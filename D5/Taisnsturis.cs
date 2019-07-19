using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Taisnsturis
    {
        //properties

        public int Mala1; // ja būtu private - tad nevienā citā klasē šo mainīgo nevarētu izmantot
        public int Mala2; // ja būtu protected, tad to varētu izmantot tikai klases, kas manto šo klasi

        // methods

        public int Laukums()
        {
            return Mala1 * Mala2;
        }

        public int Perimetrs()
        {
            return (Mala1 + Mala2) * 2;
        }

        // Constructor  Tā noskaumums vienmēr sakrīt ar klases nosaukumu un tas tiek izsaukts veidojot jaunu objektu
        public Taisnsturis()
        {

        }
        public Taisnsturis( int M1, int M2)
        {
            Mala1 = M1;
            Mala2 = M2;
        }
    }
}
