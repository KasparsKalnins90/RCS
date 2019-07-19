using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBIzsaukums
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlReader();
            EntityFramework();
            Console.Read();

        }

        static void EntityFramework()
        {

            List<Users> users = new List<Users>(); // ja gribēsim datus izmantot pēc tam, tad šo listu jāizveido ārpus using funkcijas
            using (var db = new DB5()) // tas pats, kas connection.open(), connection.close()
                {
                
                users = db.Users.OrderBy(u => u.LastName).ToList();

                }
            Console.WriteLine("Lietotāji: ");
            foreach (Users user in users)
            {
                Console.WriteLine("Id: {0}, vārds: {1} {2}", user.Id, user.FirstName, user.LastName);
            }
        }

        static void SqlReader()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\joxxx\Desktop\Visual Studio Projects\repos\RCS\OB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open(); // atveram savienojumu

            string query = "SELECT * FROM Users ORDER BY LastName";
            SqlCommand command = new SqlCommand(query, conn); // ko izpildīt un ar kuru pieslēgumu
            SqlDataReader reader = command.ExecuteReader(); // uztaisam lasītāju un izpildām datu lasīšanu
            List<UserData> users = new List<UserData>();
            while (reader.Read()) // tā kā ieraksti vairāki - Read lasīs kamēr ir ieraksti, kolīdz tabula beigsies, read kļūs false
            {
                int id = Convert.ToInt32(reader["Id"]); //reader ir masīvs, kur pēc identifikatoru mēs piekļūstam konkrētajām vērtībām
                // tā. Visas nolasītās vērtības no reader ir object datu tips, tāpēc jākonvertē
                string firstName = Convert.ToString(reader["FirstName"]);
                string lastName = Convert.ToString(reader["LastName"]);
                users.Add(new UserData()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName

                });

            }
            reader.Close(); // jāaizver, lai varētu veikt izmaiņas tabulai
            conn.Close(); // pārtrauc arī pieslēgumu datu bāzei

            Console.WriteLine("Lietotāji: ");
            foreach(UserData user in users)
            {
                Console.WriteLine("Id: {0}, vārds: {1} {2}", user.Id, user.FirstName, user.LastName);
            }
        }
    }
}
