using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class ResultController : Controller
    {
        // Action Result
       
        
            public RedirectToRouteResult Index()
            {
                return RedirectToAction("EmployeeProfile", "Employee", new { id = 1 });
            }

            public HttpNotFoundResult err()
            {
                return new HttpNotFoundResult();
            }

            public ContentResult Content()
            {
                return Content("Hello");
            } 
        }
    }
