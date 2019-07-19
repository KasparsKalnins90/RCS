using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daudzsturi;

namespace Daudzsturi
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Square s1 = new Square(5);
            s1.Perimeter();
            s1.Area();
            Triangle t1 = new Triangle(5, 3, 4);
            t1.Perimeter();
            t1.Area();
            Pentagon p1 = new Pentagon(5);
            p1.Perimeter();
            p1.Area();
            void CalculateAreaAndPerimeter(Figure f)
            {
                f.Perimeter();
                f.Area();
            }
            CalculateAreaAndPerimeter(s1);
           // CalculateAreaAndPerimeter(p1);
            CalculateAreaAndPerimeter(t1);


           

            
            
            
            
            
        }
        static void izvade(IDaudzsturis p1)
        {
            Console.WriteLine("Laukums = {0}", p1.Area());
            Console.WriteLine("Perimetrs = {0}", p1.Perimeter());
            
        }
        

    }

}
