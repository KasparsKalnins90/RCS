using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarbiniekuUzskaitesSistema
{
    class Organisation
    {

        public string Name;
        public List<Employee> Employees;

        public Organisation(string name)
        {
            Name = name;
            Employees = new List<Employee>();
            Console.WriteLine("Izveidots jauns uzņēmums: {0}", name);
        }
        //public string dzimsanasDatums;
        //List<string> darbiniekuSaraksts = new List<string>();
        //public Organisation(string Nosaukums)
        //{
        //     nosaukums = Nosaukums;
        //     Console.WriteLine("Izveidots jauns uzņēmums: {0}", nosaukums);
        // }
        public void AddEmployee(string name, string surname, string date)
        {
            // vards = Vards;
            // uzvards = Uzvards;
            //    dzimsanasDatums = DzimsanasDatums;
            //  darbiniekuSaraksts.Add(vards);
            //darbiniekuSaraksts.Add(uzvards);
            //darbiniekuSaraksts.Add(dzimsanasDatums);
            Employees.Add(new Employee(name, surname, date));
            Console.WriteLine("Pievienots jauns darbinieks - {0}, {1}.", name, surname);
            //Console.WriteLine("Pievienots jauns darbinieks {0} {1}", Name, Surname);
        }
        public void Fire(string name, string surname)
        {
            //System.Linq
            // Lambda expressions
            Employee employee = Employees.Find(e => e.Name == name && e.Surname == surname);
            if (employee == null)
            {
                Console.WriteLine("Darbinieks nav atrasts");
            }
            else
            {
                Employees.Remove(employee);
                Console.WriteLine("Atlaists darbinieks {0} {1}", name, surname);
            }

            /* for (int i = 0; i < darbiniekuSaraksts.Count; i++)
        {
            if(darbiniekuSaraksts[i] == vards && darbiniekuSaraksts[i+1] == uzvards)
            {
                darbiniekuSaraksts.RemoveAt(i);
                darbiniekuSaraksts.RemoveAt(i);
                darbiniekuSaraksts.RemoveAt(i);
                Console.WriteLine("Atlaists darbinieks {0} {1}", vards, uzvards);
            }

        }
        */
        }
        public void ChangeData(string name, string surname, string newBirthDate)
        {


            Employee employee = Employees.Find(e => e.Name == name && e.Surname == surname);
            if (employee == null)
            {
                Console.WriteLine("Darbinieks nav atrasts");
            }
            else
            {
                employee.BirthDate = newBirthDate;
                Console.WriteLine("Mainīti darbinieka {0} {1} dzimšanas dati", name, surname);
            }

            // vēl viens variants
            foreach (Employee e in Employees)
            {
                if (e.Name == name && e.Surname == surname)
                {
                    e.BirthDate = newBirthDate;
                    Console.WriteLine("Mainīti darbinieka {0} {1} dzimšanas dati", name, surname);
                    break;
                }
            }
            /*
             for (int i = 0; i < darbiniekuSaraksts.Count; i++)
             {
                 if (darbiniekuSaraksts[i] == Vards && darbiniekuSaraksts[i + 1] == Uzvards)
                 {

                     darbiniekuSaraksts[i + 2] = JaunaisDzimsanasDatums;
                     Console.WriteLine("mainīti darbinieka {0} {1} dati", Vards, Uzvards);
                 }

             }
             */

        }
        public void PrintAllEmployees()
        {
            Console.WriteLine("uzņēmumā {0} strādā:", Name);
            foreach (Employee e in Employees)
            {

                Console.WriteLine("{0} {1}, dz. {2}", e.Name, e.Surname, e.BirthDate);

                /* 
                 Console.WriteLine("uzņēmumā {0} strādā:", Name);
                 for (int i = 0; i < darbiniekuSaraksts.Count; i+=3)
                 {


                     Console.Write(darbiniekuSaraksts[i]+ " "+ darbiniekuSaraksts[i+1] + ", dz. " + darbiniekuSaraksts[i+2] + ".");
                     Console.WriteLine();

                 }
                 */
                 //vēl viens variants foreach ciklam
            }
            Employees.ForEach(e =>
           {
               Console.WriteLine("{0} {1}, dz. {2}", e.Name, e.Surname, e.BirthDate);
           });
        }
    }
}
