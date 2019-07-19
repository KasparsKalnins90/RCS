using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daudzsturi
{
    class Square : Figure
    {
        public int mala;
        public override void Area()
        {
            Console.WriteLine("The square area is " + mala * mala);
        }

        public override void Perimeter()
        {
            Console.WriteLine("the square perimeter is " + mala * 4);
        }

        public Square()
        {

        }
        public Square(int M)
        {
            mala = M;
        }
    }
}
