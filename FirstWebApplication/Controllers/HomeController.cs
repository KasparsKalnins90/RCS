using FirstWebApplication.Models;
using MovieApp.Logic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home(int? id)
        {
            Home model = new Home();
            model.Cinemas = CinemaManager.GetCinemas().Select(c => CinemaModel.FromData(c)).ToList();
            foreach(var cinema in model.Cinemas)
            {
                cinema.MovieCount = CinemaManager.CountMovies(cinema.Id);
            }
            if (id.HasValue)
            {
                model.Movies = MovieManager.GetMovies(id.Value).Select(m => MovieModel.FromData(m)).ToList();
            }
            else
            {
                model.Movies = new List<MovieModel>();
            }

            return View(model);
        }
        [HttpGet]
        public ActionResult Movie(int id)
        {
            MovieReservationModel model = new MovieReservationModel();
            model.movie = MovieModel.FromData(MovieManager.GetMovie(id)); // atlasa filmas datus pēc ID
            model.Sessions = MovieSessionManager.
                GetSessions(id).Select(s => MovieSessionModel.FromData(s))
                .ToList();// atlasa filmas seansus pēc ID
            // ielikt rezultātus modelī
            
            return View(model);
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            //seansa dati
            MovieSessionModel session = MovieSessionModel.FromData(MovieSessionManager.GetSession(id));
            var basket = Session.Get().Basket;
            basket.Add(session);

            return RedirectToAction("Movie", new { id = session.MovieId });
        }
    }
}