using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            //DzimsanasGads();
            //ParaSkaitli();
            //Min();
            //Preteji();
            //dalisana(5);
            //dalisana(6);
            //iznemot5(9);
            //modinatajs("Sv", "J");
            //fizzbuzz(1, 15);
            skaitluSerija(3);
            //varduSpele();
            Console.Read();

        }

        static void Piemers()
        {
           // for (int i = 1; i <= 100; i++)
            //{
             //   Console.WriteLine(i);
            //}
            // masīvs jeb Array
            int[] skaitli = new int[5];
            skaitli[0] = 56;
            skaitli[1] = 32;
            skaitli[2] = 44;
            skaitli[3] = 1;
            skaitli[4] = 5;
            int pirmaisSkaitlis = skaitli[0];

            for (int i = 0; i <= skaitli.Length; i++)
            {
                Console.WriteLine(skaitli[i]);
            }
        }
        static void DzimsanasGads()
        {
            Console.WriteLine("Ievadi savu dzimšanas gadu: ");
            int dzimsanasGads = int.Parse(Console.ReadLine());
            for(int i = dzimsanasGads; i<=DateTime.Now.Year; i++) //šite tiek izvlikts gads, kāds ir ierīces sistēmas uzstādījumos
            {
                Console.WriteLine(i);
            }

            // altrernativa versija bez mainīgā i
            // ja kāda daļa no info nav vajadzīga, var atstāt tukšu (šajā gadījumā i definēšana)
            //  for (;dzimsanasGads<=2019; dzimsanasGads++)
        }
        static void ParaSkaitli()
        {
            Console.WriteLine("Ievadi skaitli: ");
            int skaitlis = int.Parse(Console.ReadLine());
            int summa = 0;
            for(;skaitlis>0; skaitlis--)
            {
                if(skaitlis%2 == 0)
                {
                    Console.WriteLine(skaitlis);
                    summa += skaitlis;
                }
                

            }
            Console.WriteLine("Visu pāra skaitļu summa ir: {0}", summa);

        }
        static void Min()
        {
            int[] skaitli = new int[5];
            for(int i = 0; i<skaitli.Length; i++)
            {
                Console.WriteLine("ievadi {0}. skaitli: ", i+1);
                skaitli[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("mazākais skaitlis masīvā ir: {0}", skaitli.Min());
        }
        static void Preteji()
        {
            Console.WriteLine("Cik skaitļus vēlēsies ievadīt?");
            int skaitluDaudzums = int.Parse(Console.ReadLine());
            int[] skaitli = new int[skaitluDaudzums];
            for (int i = 0; i < skaitli.Length; i++)
            {
                Console.WriteLine("ievadi {0}. skaitli: ", i + 1);
                skaitli[i] = int.Parse(Console.ReadLine());
            }

            for (int i = skaitli.Length-1; i >=0; i--)
            {
                Console.WriteLine(skaitli[i]);
            }
        }
        static void dalisana(int skaitlis)
        {
            if (skaitlis % 3 == 0)
            {
                Console.WriteLine("jā");
            }
            else
            {
                Console.WriteLine("nē");
            }
        }
        static void iznemot5(int N)
        {
            for (int i = 0; i < N; i++)
            {
                if (i != 5) {
                    Console.Write(i + ", ");
                    
                    }
                
                }
            Console.Write(N);
        }

        static void modinatajs(string diena, string atvalinajums)
        {
            if(atvalinajums == "J" && ((diena == "P") || (diena == "O") || (diena == "T") || (diena == "C") || (diena == "Pk"))){
                Console.WriteLine("10:00");
            } else if (atvalinajums == "N" && ((diena == "P") || (diena == "O") || (diena == "T") || (diena == "C") || (diena == "Pk"))){
                Console.WriteLine("7:00");
            } else if (atvalinajums =="J" && ((diena=="Se") || (diena == "Sv")))
            {
                Console.WriteLine("off");
            }
            else if (atvalinajums == "N" && ((diena == "Se") || (diena == "Sv")))
            {
                Console.WriteLine("10:00");
            }

            // šādus daudz efektīvāk risināt ar switch.
        }
        static void fizzbuzz(int A, int B)
        {
            string number = "";
            for(int i = A; i<=B; i++)
            {
                if(i%5 ==0 && i % 3 == 0)
                {
                    number = "fizzbuzz";
                } else if (i%3 == 0)
                {
                    number = "fizz";
                } else if (i%5 == 0)
                {
                    number = "buzz";
                } else
                {
                    number = i.ToString();
                }
                Console.Write("{0}, ", number);
            }
        }
        static void skaitluSerija(int sk)
        {
           
            for (int grupa = 1; grupa<=sk; grupa++ )
            {
                for(int j =1; j<=grupa;j++)
                {
                    Console.Write("{0}", j);
                }
            }
        }
        static void varduSpele()
        {
            string[] vardi = new string[3];
            Random rand = new Random();

            vardi[0] = "cuka";
            vardi[1] = "vilks";
            vardi[2] = "kamielis";
            string minamaisVards = vardi[rand.Next(02)];
            Console.WriteLine("Uzmināmā vārda garums ir {0} burti", minamaisVards.Length);
            for (int i = 1; i <= minamaisVards.Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
            string minejums = Console.ReadLine();
            int bija = 0;
            for (int i = minejums.Length-1; i >= 0; i--)
            {
                for (int j = 0; j <= minamaisVards.Length - 1; j++)
                    if (minejums[i] == minamaisVards[j])
                    {
                        Console.Write(minejums[i]);
                        bija++;
                    
                    } else 
                    {
                        Console.Write("_");
                    }
                if (bija == 0)
                {

                    Console.WriteLine("Minētais burts {0} nav šajā vārdā", minejums[i]);
                    break;

                }
            }
        }
    }
}
