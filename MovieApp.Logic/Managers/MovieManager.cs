using MovieApp.Logic.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Logic.Managers
{
/// <summary>
/// Filmu Pārvaldnieks
/// </summary>
    public class MovieManager
    {
        /// <summary>
        /// Pilns Filmu saraksts
        /// </summary>
        /// <returns>saraksts ar filmām</returns>
        public static List<Movie> GetMovies() 
        {
            using (var db = new DB())
            {
                return db.Movies.OrderBy(m => m.Title).ToList();
            }
        }
        /// <summary>
        /// Filmu atlase pēc kinoteātra
        /// </summary>
        /// <param name="cinemaId"> Kinoteātra ID</param>
        /// <returns>saraksts ar filmām</returns>
            public static List<Movie> GetMovies(int cinemaId)
            {
                using (var db = new DB())
                {
                    return db.Movies.Where(m => m.CinemaId == cinemaId).OrderBy(m => m.Title).ToList();
                }
            }
        /// <summary>
        /// Filmas atlase
        /// </summary>
        /// <param name="id">Filmas ID</param>
        /// <returns>Filmas dati</returns>
        public static Movie GetMovie(int id)
        {
            using (var db = new DB())
            {
                return db.Movies.Find(id);
            }
        }
        /// <summary>
        /// Dzēš filmu pēc identifikatora
        /// </summary>
        /// <param name="id">Filmas ID</param>
        public static void Delete(int id)
        {
            using(var db = new DB())
            {
                db.Movies.Remove(db.Movies.Find(id));

                db.SaveChanges();
            }
            
        }
        /// <summary>
        /// Jaunas Filmas pievienošana
        /// </summary>
        /// <param name="movies">info par jauno filmu</param>
        /// <returns>pievienotā filma</returns>
        public static Movie Create(Movie movie)
        {

            using (var db = new DB())
            {
                movie = db.Movies.Add(movie);
                db.SaveChanges();
                return movie;
            }
        }
        /// <summary>
        /// Filmas informācijas atjaunošana
        /// </summary>
        /// <param name="movie"> filmas ID</param>
        /// <returns>filmas dati</returns>
        public static Movie Update(Movie movie)
        {
            using (var db = new DB())
            {
                var existing = db.Movies.Find(movie.Id);
                existing.Title = movie.Title;
                existing.Year = movie.Year;

                db.SaveChanges();

                return existing;
            }

        }
    }
}
