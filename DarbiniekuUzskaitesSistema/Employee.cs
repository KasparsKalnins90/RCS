using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarbiniekuUzskaitesSistema
{
    class Employee
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }

        public Employee(string name, string surname, string birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }
    }
}
