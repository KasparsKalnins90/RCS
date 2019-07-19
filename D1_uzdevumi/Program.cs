using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            //PecDesmitGadiem();
            //Pilngadigs();
            //LietotajaVards();
            //aprekins();
            //Galvaspilseta();
            //Reizinajums();
            //Vienadi();
            //TrisVardi();
            //UzLielajiem();
            //MinMax();
            //ParaSkaitlis();
            Console.Read();
        }
        static void MinMax()
        {

            /*
             * 
             * Saīsinātais if else
             * shorthand if
             * NOSACĪJUMS ? IR PATIESS (TAD): NAV PATIESS(citādi)
             * 
             * int min2 = sk1 < sk2 ? sk1 : sk2;
             * 
             * 
             * 
             * Variants ar Min() un Max()
             * int min3 = Math.Min(Math.Min(sk1, sk2), sk3));
             * int max3 = Math.Max(Math.Max(sk1, sk2), sk3));
             * 
             */
            Console.WriteLine("ievadi pirmo skaitli: ");
            int pirmaisSkaitlis = int.Parse(Console.ReadLine());
            Console.WriteLine("ievadi otro skaitli: ");
            int otraisSkaitlis = int.Parse(Console.ReadLine());
            Console.WriteLine("ievadi trešo skaitli: ");
            int tresaisSkaitlis = int.Parse(Console.ReadLine());

            if(pirmaisSkaitlis > otraisSkaitlis && pirmaisSkaitlis > tresaisSkaitlis)
            {
                Console.WriteLine("Lielākais skaitlis ir " + pirmaisSkaitlis);
            } else if (otraisSkaitlis > pirmaisSkaitlis && otraisSkaitlis > tresaisSkaitlis)
            {
                Console.WriteLine("Lielākais skaitlis ir " + otraisSkaitlis);
            } else
            {
                Console.WriteLine("Lielākais skaitlis ir " + tresaisSkaitlis);
            }
            if(pirmaisSkaitlis< otraisSkaitlis && pirmaisSkaitlis < tresaisSkaitlis)
            {
                Console.WriteLine("Mazākais skaitlis ir " + pirmaisSkaitlis);
            } else if (otraisSkaitlis < pirmaisSkaitlis && otraisSkaitlis < tresaisSkaitlis)
            {
                Console.WriteLine("Mazākais skaitlis ir " + otraisSkaitlis);
            } else if (tresaisSkaitlis < otraisSkaitlis && tresaisSkaitlis < pirmaisSkaitlis)
            {
                Console.WriteLine("Mazākais skaitlis ir " + tresaisSkaitlis);
            }


        }
        static void LietotajaVards()
        {
            Console.Write("Ievadi vārdu: ");
            
            string vards = Console.ReadLine();
            Console.Write("Ievadu uzvārdu: ");
            string uzvards = Console.ReadLine();
            //Console.WriteLine("Tevi sauc " + vards + " " + uzvards);
            // Cits variants kā pierakstīt.
            Console.WriteLine("Tevi sauc {0} {1} ", vards, uzvards);
        }
        static void PecDesmitGadiem()
        {
            Console.WriteLine("Ievadi vecumu");
            int vecums = int.Parse(Console.ReadLine());
            vecums += 10;
            Console.WriteLine("Pēc desmit gadiem tu būsi {0} gadus vecs", vecums);
            Console.Read();
        }

        static void Pilngadigs()
        {
            Console.WriteLine("Ievadi vecumu");
            int vecums = int.Parse(Console.ReadLine());

            if(vecums >= 18)
            {
                Console.WriteLine("Tu jau esi pilngadīgs");
            } else if (vecums < 18 && vecums >= 0)
            {
                Console.WriteLine("Tu vēl neesi pilngadīgs");
            } else
            {
                Console.WriteLine("Neticu, ka tu vēl neesi piedzimis!");
            }
        }
        static void aprekins()
        {
            Console.WriteLine("Ko vēlies darīt ar skaitļiem?");
            string darbiba = Console.ReadLine();
            Console.WriteLine("ievadi pirmo skaitli: ");
            int pirmaisSkaitlis = int.Parse(Console.ReadLine());
            Console.WriteLine("ievadi otro skaitli: ");
            int otraisSkaitlis = int.Parse(Console.ReadLine());
            int rezultats = 0;
            if(darbiba == "+")
            {
                rezultats = pirmaisSkaitlis + otraisSkaitlis;
                Console.WriteLine("rezultāts ir {0}", rezultats);
            } else if (darbiba == "*")
            {
                rezultats = pirmaisSkaitlis * otraisSkaitlis;
                Console.WriteLine("rezultāts ir {0}", rezultats);
            }
            else if (darbiba == "/")
            {
                if (otraisSkaitlis == 0 && darbiba == "/")
                {
                    Console.WriteLine("ar nulli dalīt nedrīkst!");
                }
                else
                {
                    rezultats = pirmaisSkaitlis / otraisSkaitlis;
                    Console.WriteLine("rezultāts ir {0}", rezultats);
                }
            }
            else if (darbiba == "-")
            {
                rezultats = pirmaisSkaitlis - otraisSkaitlis;
                Console.WriteLine("rezultāts ir {0}", rezultats);
            }
            else 
            {
                Console.WriteLine("Darbību nav iespējams veikt, jo kaut kas nav ievadīts pareizi");
            }
        }
        static void kalkulators()
        {
            // vēl viens veids, kā tikt galā ar aprēķina uzdevumu
            // ja ir zināmas reālās iespējamās vērtības  labāk lietot switch statement, nekā if, jo tad programma strādās ātrāk.
            Console.WriteLine("Ko vēlies darīt ar skaitļiem?");
            string darbiba = Console.ReadLine();
            Console.WriteLine("ievadi pirmo skaitli: ");
            int pirmaisSkaitlis = int.Parse(Console.ReadLine());
            Console.WriteLine("ievadi otro skaitli: ");
            int otraisSkaitlis = int.Parse(Console.ReadLine());
            switch (darbiba)
            {
                case "+":
                    Console.WriteLine("rezultāts ir {0}", pirmaisSkaitlis + otraisSkaitlis);
                    break;
                case "-":
                    Console.WriteLine("rezultāts ir {0}", pirmaisSkaitlis - otraisSkaitlis);
                    break;
                case "*":
                    Console.WriteLine("rezultāts ir {0}", pirmaisSkaitlis * otraisSkaitlis);
                    break;
                case "/":
                    Console.WriteLine("rezultāts ir {0}", pirmaisSkaitlis / otraisSkaitlis);
                    break;
                default:
                    Console.WriteLine("Darbība nav atļauta");
                    break;
            }
        }
        static void Reizinajums()
        {
            Console.WriteLine("Ievadi pirmo skaitli");
            int pirmais = int.Parse(Console.ReadLine());
            Console.WriteLine("Ievadi otro skaitli");
            int otrais = int.Parse(Console.ReadLine());
            Console.WriteLine("Ievadi trešo skaitli");
            int tresais = int.Parse(Console.ReadLine());
            Console.WriteLine("Skaitļu reizinājums ir " + pirmais * otrais * tresais);
        }
        static void Galvaspilseta()
        {
            Console.WriteLine("Ievadi valsts nosaukumu");
            string valsts = Console.ReadLine();
            switch (valsts)
            {
                case "Latvija":
                    Console.WriteLine("Rīga");
                    break;
                case "Igaunija":
                    Console.WriteLine("Tallina");
                    break;
                case "Somija":
                    Console.WriteLine("Helsinki");
                    break;
                case "Ukraina":
                    Console.WriteLine("Kijeva");
                    break;
                case "Zviedrija":
                    Console.WriteLine("Stokholma");
                    break;
                case "Krievija":
                    Console.WriteLine("Maskava");
                    break;
                default:
                    Console.WriteLine("Šī valsts nav datu bāzē");
                    break;
            }
        }
        static void Vienadi()
        {
            Console.WriteLine("Ievadi pirmo skaitli");
            int pirmais = int.Parse(Console.ReadLine());
            Console.WriteLine("Ievadi otro skaitli");
            int otrais = int.Parse(Console.ReadLine());
            if (pirmais == otrais)
            {
                Console.WriteLine("Skaitļi ir vienādi");
            }
            else Console.WriteLine("Skaitļi nav vienādi");
        }
        static void TrisVardi()
        {
            Console.WriteLine("Ievadi pirmo vārdu: ");
            string pirmais = Console.ReadLine();
            Console.WriteLine("Ievadi otro vārdu: ");
            string otrais = Console.ReadLine();
            Console.WriteLine("Ievadi trešo vārdu: ");
            string tresais = Console.ReadLine();
            Console.WriteLine("{0},{1},{2}", pirmais, otrais, tresais);
        }
        static void UzLielajiem()
        {
            Console.WriteLine("ievadiet tekstu: ");
            string lielie = Console.ReadLine().ToUpper();
            Console.WriteLine(lielie);

        }
        static void ParaSkaitlis()
        {
            Console.WriteLine("ievadiet skaitli: ");
            int skaitlis = int.Parse(Console.ReadLine());
            if(skaitlis%2 == 0)
            {
                Console.WriteLine("{0} ir pāra skaitlis!", skaitlis);
            }
            else
            {
                Console.WriteLine("{0} nav pāra skaitlis!", skaitlis);
            }
        }
    }

}
