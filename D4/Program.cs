using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Program
    {
        static void Main(string[] args)
        {
            //dimants();
            //minesana();
            //trijsturis();
            //stop13();
            //sum();
            //firstLast();
            Console.Read();

        }


        static void rezgis()
        {
            Console.WriteLine("Ievadi skaitli: ");
            int skaitlis = int.Parse(Console.ReadLine());
            for(int i = 0; i<skaitlis; i++)
            {
                
                for (int j = 0; j< skaitlis; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        static void trijsturis()
        {
            Console.Write("ievadi skaitli: ");
            int skaitlis = int.Parse(Console.ReadLine());
            for (int i = 1; i <= skaitlis; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
        static void minesana()
        {
            
            int skaitlis =  new Random().Next(0, 300);
            int minejumuSkaits = 0;
            while (true)
                
            {
                Console.Write("Uzmini skaitli: ");
                
                int minejums = int.Parse(Console.ReadLine());
                if (minejumuSkaits < 5)
                {
                    if (minejums > skaitlis && minejumuSkaits < 5)
                    {
                        Console.WriteLine("Skaitlis ir mazāks, nekā tavs minējums");
                        minejumuSkaits++;
                    }
                    else if (minejums < skaitlis && minejumuSkaits < 5)
                    {
                        Console.WriteLine("Skaitlis ir lielāks, nekā tavs minējums");
                        minejumuSkaits++;
                    }
                    else
                    {
                        Console.WriteLine("Tu uzminēji! skaitlis bija {0}", skaitlis);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Tu pārsniedzi aļauto minējumu skaitu");
                    break;
                }
            }
        }
        static void dimants()
        {
            Console.Write("Ievadi skaitli N: ");
            int N = int.Parse(Console.ReadLine());

            /*
             *  N = 3 
             *     *        r = 1, a = 2 = N - r, z = 1 = 2*r-1
             *    ***       r= 2, a = 1, z = 3
             *   *****      r = 3, a = 0, z = 5
             *    ***
             *     *
             * 
             * 
             */ 

            for(int r = 0; r<= N; r++)
            {
                for (int a = 1; a <= N - r; a++)
                {
                    for (int z = 1; z <= 2 * r - 1; z++)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                }
                
                Console.WriteLine();
            }
            for(int r = N-1; r >= 1; r--)
            {
                for (int a = 1; a <= N - r; a++)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= 2 * r - 1; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



        }
        static void stop13()
        {
            
            int summa = 0;
            while (true)
            {
                Console.Write("Ievadi skaitli: ");
                int skaitlis = int.Parse(Console.ReadLine());
                if (skaitlis == 13)
                {
                    Console.WriteLine("līdz šim ievadīto skaitļu summa ir {0}", summa);
                    break;

                }
                else
                {
                    summa += skaitlis;
                }
            }
        }
        static void sum()
        {
            Console.Write("Ievadi skaitli: ");
            string skaitlis = Console.ReadLine();
            int summma = 0;
            for(int i = 0; i<= skaitlis.Length-1; i++)
            {
                summma += int.Parse(skaitlis[i].ToString());
            }
            Console.WriteLine("skaitļa ciparu summa ir {0}", summma);

            /*      Ja iespējams strādāt tikai ar skaitļiem tad var darīt šitā.
             * int skaitlis = int.Parse(Console.Readline());
             * 
             * int sum = 0;
             * while(skaitlis !=0)
             * 
              {
             *      sum += skaitlis%10;
             *      skaitlis/=10;
              }
             */
        }
        static void firstLast()
        {
            List<int> skaitli = new List<int>();
            
            while (true)
            {
                Console.Write("ievadi skaitli: ");
                string ievaditais = Console.ReadLine();
                if (ievaditais != "exit")
                {
                   int ievaditaisSkaitlis =  int.Parse(ievaditais);
                    skaitli.Add(ievaditaisSkaitlis);
                } else
                {
                    break;
                }
            }
            if(skaitli[0] == skaitli[skaitli.Count - 1])// if (skaitli.FirstOrDefault() == skaitli.LastOrDefault()) strādās arī ja saraksts būs tukšs
            {
                Console.WriteLine("Pirmais ievadītais skaitlis ir vienāds ar pēdējo ievadīto");
            } else
            {
                Console.WriteLine("Pirmais ievadītais skaitlis nav vienāds ar pēdējo ievadīto");
            }

        }
    }
}
