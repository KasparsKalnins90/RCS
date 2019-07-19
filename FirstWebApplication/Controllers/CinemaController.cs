using FirstWebApplication.Models;
using MovieApp.Logic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApplication.Controllers
{
    public class CinemaController : Controller
    {
        // GET: Cinema
        public ActionResult Index()
        {
            List<CinemaModel> cinemas = CinemaManager.GetCinemas().Select(c=> CinemaModel.FromData(c)).ToList();
           
            return View(cinemas);
        }
        [HttpGet] // get nozīmē apskates forma
        public ActionResult Edit(int? id) // šis bloks nepieciešams lietotāja datu attēlošanai . Jautājuma zīme norāda, ka id var būt tukšs
        {
            CinemaModel cinema = null; // jādefinē kinoteātris, kas jālabo vai jāpievieno
            if (id.HasValue) // ja ID ir definēts, tiek veikta rediģēšana
            {
                cinema = CinemaModel.FromData(CinemaManager.GetCinema(id.Value));
                cinema.Movies = MovieManager.GetMovies(id.Value).Select(m => MovieModel.FromData(m)).ToList();
            } else
            {
                cinema = new CinemaModel(); // ja id nav definēts, tad kinoteātri neatlasam, pievienojam tukšu, lai nav problēmas ar Id lauku
            }
            return View(cinema);
        }

        [HttpPost] // post nozīmē datu iesūtīšana
        public ActionResult Edit(CinemaModel cinema)
        {
            if (ModelState.IsValid) // iebūvēta funkcija, kas pārbauda vai dati atbilst definētajiem 
            {
                
                if(cinema.Id != 0) // ja Id ir nav definēts, tad labojam
                {
                    CinemaManager.Update(cinema.ToData());
                }
                else
                {
                    CinemaManager.Create(cinema.ToData());
                }
                    
            }
            return View(cinema);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {

            CinemaManager.Delete(id);

            return RedirectToAction("Index");
        }

    }
    
}