using FirstWebApplication.Models;
using MovieApp.Logic.Database;
using MovieApp.Logic.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace FirstWebApplication.Controllers

{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            if (ModelState.IsValid) {
                string error = UserManager.Register(new MovieApp.Logic.Database.User()
                {
                    Email = user.Email,
                    Name = user.Name,
                    Password = user.Password
                    });
                if (error == null)
                {
                    return RedirectToAction("Login");
                }
                else
                    ModelState.AddModelError("", error);
            }
            
            return View(user);
        }
        [HttpGet]
        public ActionResult Register(string Email)
        {
            
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            
            if (ModelState.IsValid)
            {
                User user = UserManager.Login(model.Email, model.Password);
                if(user == null)
                {
                    ModelState.AddModelError("", "Nepareizs epasts/parole");
                }
                else
                {
                    Session.Set(new UserSessionModel()
                    {
                        User = UserModel.FromData(user)
                    });
                    return RedirectToAction("Home", "Home");
                }
                
            }
            return View();
        }
        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Home", "Home");
        }
        [HttpGet]
        public ActionResult MyBasket()
        {
            return View(Session.Get().Basket);
        }
    }
}