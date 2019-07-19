using FirstWebApplication.Models;
using MovieApp.Logic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace FirstWebApplication.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            List<MovieModel> movies = new List<MovieModel>();
            movies = MovieManager.GetMovies().Select(m => MovieModel.FromData(m)).ToList();
            return View(movies);
        }
        [HttpGet]
        public ActionResult Edit(int? id) // šis bloks nepieciešams lietotāja datu attēlošanai . Jautājuma zīme norāda, ka id var būt tukšs
        {
            MovieModel movie = null; // jādefinē kinoteātris, kas jālabo vai jāpievieno
            if (id.HasValue) // ja ID ir definēts, tiek veikta rediģēšana
            {
                movie = MovieModel.FromData(MovieManager.GetMovie(id.Value));
                movie.MovieSessions = MovieSessionManager.GetSessions(id.Value).
                    Select(s => MovieSessionModel.FromData(s)).ToList();
            }
            else
            {
                movie = new MovieModel(); // ja id nav definēts, tad kinoteātri neatlasam, pievienojam tukšu, lai nav problēmas ar Id lauku
            }
            return View(movie);
        }


        [HttpPost] // post nozīmē datu iesūtīšana
        public ActionResult Edit(MovieModel model)
        {
            if (ModelState.IsValid) // iebūvēta funkcija, kas pārbauda vai dati atbilst definētajiem 
            {
               
                    if (model.Id != 0) // ja Id ir nav definēts, tad labojam
                    {
                    MovieManager.Update(model.ToData());

                    }
                    else
                    {
                        MovieManager.Create(model.ToData());
                    }
   
            }
            return RedirectToAction("Edit", "Cinema", new { id = model.CinemaId });
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {

           
                MovieManager.Delete(id);
            


            return RedirectToAction("Index");
        }
    }
}