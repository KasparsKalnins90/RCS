using FirstWebApplication.Models;
using MovieApp.Logic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApplication.Controllers
{
    public class MovieSessionController : Controller
    {
        // GET: MovieSession
        public ActionResult Index(int movieId)
        {
            List<MovieSessionModel> sessions = new List<MovieSessionModel>();
            sessions = MovieSessionManager.GetSessions(movieId).Select(s => MovieSessionModel.FromData(s)).ToList();
            return View(sessions);
            
        }
        [HttpGet]
        public ActionResult Edit(int? id, int movieId) 
        {
            MovieSessionModel session = null; 
            if (id.HasValue) 
            {
                session = MovieSessionModel.FromData(MovieSessionManager.GetSession(id.Value));
            }
            else
            {
                session = new MovieSessionModel();
                session.MovieId = movieId;
            }
            return View(session);
        }
        [HttpPost] 
        public ActionResult Edit(MovieSessionModel model)
        {
            if (ModelState.IsValid) 
            {
                if (model.Id != 0) 
                {
                    MovieSessionManager.Update(model.ToData());
                }
                else
                {
                    MovieSessionManager.Create(model.ToData());
                }
            }
            return RedirectToAction("Edit", "Session", new { id = model.MovieId });
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            MovieSessionManager.Delete(id);
            return RedirectToAction("Index");
        }
    }
}