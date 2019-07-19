using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{

    // Inheritence
    class Kvadrats : Taisnsturis // šādi paplašinām klasi - visas publiskās lietas ir pieejamas
    {
        public Kvadrats(int mala)
            : base(mala, mala) // izsaukt bāzes klases konstruktoru
        {
            // var nerakstīt ": base (mala, mala), bet tā vietā rakstīt Mala1 = mala; Mala2 = mala;
        }

    }
}
