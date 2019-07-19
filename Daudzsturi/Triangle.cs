using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daudzsturi
{
    class Triangle : Figure
    {
        public int mala1;
        public int mala2;
        public int mala3;
        public override void Area()
        {
            int puseNoPerimetra = (mala1 + mala2 + mala3) / 2;
            double laukums = Math.Sqrt((puseNoPerimetra * (puseNoPerimetra - mala1) * (puseNoPerimetra - mala2) * (puseNoPerimetra - mala3)));
            Console.WriteLine("The triangle area is {0}", laukums);
        }

        public override void Perimeter()
        {
            Console.WriteLine("the triangle perimeter is "+ mala1 + mala2 + mala3);
        }

        public Triangle()
        {

        }
        public Triangle(int M1, int M2, int M3)
        {
            mala1 = M1;
            mala2 = M2;
            mala3 = M3;
        }
    }
}
