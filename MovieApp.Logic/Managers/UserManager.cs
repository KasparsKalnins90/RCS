using MovieApp.Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Logic.Managers
{
    public class UserManager
    {
        public static string Register(User user)
        {
            using(var db = new DB())
            {
                if(db.Users.Any(u=> u.Email == user.Email))
                {
                    return "Šāds lietotājs jau eksistē!";
                }
                db.Users.Add(user);
                db.SaveChanges();
                return null;
            }
        }
        public static User Login(string email, string password)
        {
            using(var db = new DB())
            {
                return db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            }
        }
    }
}
