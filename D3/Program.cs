using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            //skaitli10();
            iepirksanas2();
            Console.Read();

        }
        static void Piemers()
        {
            //jauna saraksta izveidošana (nav jānorāda izmērs)
            List<int> skaitli = new List<int>();
            skaitli.Add(5);
            skaitli.Add(78);
            skaitli.Add(-10);
            //lai izvadītu visu listā esošo
            for(int i = 0; i<skaitli.Count; i++)
            {
                Console.WriteLine(skaitli[i]);
            }
            skaitli.RemoveAt(2); // izvākt skaitli no konkrētas pozīcijas
            skaitli.Insert(1, 1000); // šādi var ievietot skaitli konkrētā pozīcijā
            int min = skaitli.Min();
            int max = skaitli.Max();
            //ar foreach var iziet cauri visām saraksta vērtībām (bet neredzam pozīcijas)
            foreach(int sk in skaitli)
            {
                Console.WriteLine(sk);
            }
        }
        static void skaitli10()
        {
            List<int> skaitli = new List<int>();
            Console.WriteLine("Ievadi skaitli");
            for (; ; )
            {
                string ievadītais = Console.ReadLine();
                int skaits = 0;
                if (ievadītais == "exit")
                {
                    foreach (int sk in skaitli)
                    {
                        if (sk == 10)
                        {
                            skaits++;
                        }
                        
                    }
                    Console.WriteLine("Tika ievadīti {0} skaitļi 10", skaits);
                    break;

                }
                else
                {
                    skaitli.Add(int.Parse(ievadītais));
                    Console.WriteLine("Ievadi nākamo skaitli");
                    
                }
            }
        }
        static void iepirksanas2()
        {
            string[] preces = { "dators", "bikses", "auto" };
            int[] cenas = { 900, 50, 10000 };
            List<string> grozs = new List<string>();
            for (int i = 0; i < preces.Length; i++)
            {
                Console.WriteLine("{0} maksā {1} eiro", preces[i], cenas[i]);

            }
            while (true)
            {
                Console.Write("Ievadi preces nosaukumu: ");
                string nosaukums = Console.ReadLine();
                if(nosaukums == "0")
                {
                    break;
                }
                grozs.Add(nosaukums);
            }


            int summa = 0;
            foreach(string prece in grozs)
            {
                bool irAtrasts = false;
                for(int i = 0; i < preces.Length; i++)
                {
                    if(preces[i].ToLower() == prece.ToLower())
                    {
                        summa += cenas[i];
                        irAtrasts = true;
                        break;
                    }
                }
                if (!irAtrasts)
                {
                    Console.WriteLine("Prece nav atrasta");
                }
            }
            Console.WriteLine("{0} ir kopējā summa", summa);
            
        }
        static void iepirksanas()
        {
            List<string> preces = new List<string>();
            List<int> cenas = new List<int>();
            preces.Add("dators");
            preces.Add("bikses");
            preces.Add("auto");
            preces.Add("mobilais");
            preces.Add("tv");
            preces.Add("koferis");
            preces.Add("cimdi");
            preces.Add("cepure");
            cenas.Add(900);
            cenas.Add(50);
            cenas.Add(100000);
            cenas.Add(200);
            cenas.Add(550);
            cenas.Add(100);
            cenas.Add(20);
            cenas.Add(10);

            for(int i = 0; i< preces.Count; i++)
            {
                Console.WriteLine("{0} maksā {1} eiro", preces[i], cenas[i]);
                
            }
            int pirkumaSumma = 0;
            for (; ; )
                // vai while(true)
               
            {
                Console.WriteLine("izvēlies preci ierakstot tās nosaukumu (ja vēlies pabeigt pirkumu, raksti 0)");
                string pirkums = Console.ReadLine().ToLower();
                for (int i = 0; i< preces.Count; i++)
                {
                    if(preces[i] == pirkums)
                    {
                        pirkumaSumma += cenas[i];
                    }
                }
                if(pirkums== "0")
                {
                    Console.WriteLine("kopējā pirkuma summa ir {0}", pirkumaSumma);
                    break;
                }


            }
        }
    }
}
