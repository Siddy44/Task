using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Models.ViewModel;

namespace WebApplication.Controllers
{
    public class MovieDetailController : Controller
    {


        [Route("MovieDetail")]
            public ActionResult Popcorn()
            {
                var hello = new Movies() { Title = "Mission Impossible!",Rating=7.7 };

              

                var customers = new List<Customer>
            {
                 new Customer {Name="Eric" },
                 new Customer {Name="Hitler" }
            };







                var obj = new RandomViewModel()
                {
                    Movie = hello,
                    customers = customers,

                };

                return View(obj);
                
            }
        }
    }
