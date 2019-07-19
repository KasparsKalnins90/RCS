using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarbiniekuUzskaitesSistema
{
    class Program
    {
        static void Main(string[] args)
        {

            Organisation org = new Organisation("SIA mans uzņēmums");
            org.AddEmployee("Kaija", "Putniņa", "01/01/1980");
            org.AddEmployee("Dzidra", "Zupa", "25/05/1979");
            org.AddEmployee("Rudolfs", "Briedis", "24/12/1983");
            org.Fire("Dzidra", "Zupa");
            org.ChangeData("Rudolfs", "Briedis", "24/12/1973");
            org.PrintAllEmployees();
            Console.Read();
        }
    }
}
