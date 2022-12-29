using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class MovieController : Controller
    {
        // MVC IN ACTION
        public ActionResult Index()
        {
            Movies obj = new Movies() { Title = "Avatar", Rating = 8.2 };
            return View(obj);
        }
    }
}