using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class ParaActionController : Controller
    {
       //Parametrised Action
        public ActionResult Def(int id)  //default parameter
        {
            return Content("id is "+id);
        }
      
            public ActionResult Index(int year,int ? month)
            {
            return Content("year " + year + " optional/month " +month );
            }
        
    }
}