using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aprekini();

            Console.Read();


           // skaits = vards.Count(burts => burts == 'e' || burts == 'E');  īsākais pieraksts tam, kā saskaitīt simbolus stringā.
        }
        static void Aprekini()
        {
            Taisnsturis t1 = new Taisnsturis();
            t1.Mala1 = 5;
            t1.Mala2 = 4;

            Taisnsturis t2 = new Taisnsturis(50, 25);
            
            Console.WriteLine("Taisnstūra perimetrs ir {0}", t1.Perimetrs());
            Console.WriteLine("Taisnstūra laukums ir {0}", t1.Laukums());
            Console.WriteLine("Taisnstūra 2 perimetrs ir {0}", t2.Perimetrs());


            Aplis a1 = new Aplis(4, "zaļš");
            Console.WriteLine("Apļa perimetrs ir {0}, laukums ir {1}, un krāsa ir {2}", a1.Perimetrs(), a1.Laukums(), a1.KrasasNosaukums());


            Kvadrats k1 = new Kvadrats(4);
            Console.WriteLine("kvadrāta perimetrs ir {0}, kvadrāda laukums ir {1}", k1.Perimetrs(), k1.Laukums());


        }
    }
}
