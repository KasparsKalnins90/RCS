using MovieApp.Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Logic.Managers
{
    public class CinemaManager
    {
        public static Cinema Create(Cinema cinema)
        {
            using (var db = new DB())
            {
                cinema = db.Cinemas.Add(cinema);
                db.SaveChanges();
                return cinema;
            }
        }
        /// <summary>
        /// kinoteātra dzēšana
        /// </summary>
        /// <param name="id">kinoteātra ID</param>
        public static void Delete(int id)
        {
            using (var db = new DB())
            {
                db.Movies.RemoveRange(db.Movies.Where(m => m.CinemaId == id));
                db.Cinemas.Remove(db.Cinemas.Find(id));

                db.SaveChanges();
            }
        }
        /// <summary>
        /// Datu atjaunošana
        /// </summary>
        /// <param name="cinema">kinoteātris</param>
        /// <returns>atjaunotie dati</returns>
        public static Cinema Update(Cinema cinema)
        {
            using (var db = new DB())
            {
                var existing = db.Cinemas.Find(cinema.Id);
                existing.Name = cinema.Name;
                existing.Address = cinema.Address;

                db.SaveChanges();

                return existing;
            }
        }
        /// <summary>
        /// Kinoteātra atlase
        /// </summary>
        /// <param name="id">Kinoteātra ID</param>
        /// <returns>Kinoteātris</returns>
        public static Cinema GetCinema(int id)
        {
            using (var db = new DB())
            {
                return db.Cinemas.Find(id);
            }
        }
        /// <summary>
        /// Kinoteātru atlase
        /// </summary>
        /// <returns>Kinoteātru saraksts</returns>
        public static List<Cinema> GetCinemas()
        {
            using (var db = new DB())
            {
                return db.Cinemas.OrderBy(c => c.Name).ToList();
            }

        }
        /// <summary>
        /// Filmu skaits pēc kinoteātra
        /// </summary>
        /// <param name="cinemaId">kinoteātra ID</param>
        /// <returns>filmu skaits</returns>
        public static int CountMovies(int cinemaId)
        {
            using (var db = new DB())
            {
                return db.Movies.Count(m => m.CinemaId == cinemaId);
            }
        }
    }
}
