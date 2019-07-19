using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daudzsturi
{
    class Pentagon : IDaudzsturis
    {
        public double mala;

        public double  Perimeter()
        {
            Console.WriteLine("the pentagon perimeter is "+ mala * 5);
            return mala * 5;
        }
        public double Area()
        {
            double area = mala * mala * Math.Sqrt((25 + (10 * Math.Sqrt(5))) / 4);
            Console.WriteLine("the pentagon area is {0}", area);
            return area;
        }

        public Pentagon()
        {

        }
        public Pentagon(int M)
        {
            mala = M;
        }
        


    }
}
