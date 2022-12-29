using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    //JsonResult Type
    public class JsonDemoController : Controller
    {
        public JsonResult Index()
        {
            JsonData myobj = new JsonData()
            {
                id = 1,
                name = "Sid",
                email = "sidd@gmail.com"
            };
            var data = JsonConvert.SerializeObject(myobj);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Folder()
        {
            JsonData myobj = new JsonData()
            {
                id = 1,
                name = "Sid",
                email = "sidd@gmail.com"
            };
            string path = "F://MvcJson.txt";
            string jsonData = JsonConvert.SerializeObject(myobj);
            System.IO.File.WriteAllText(path, jsonData);
            return Json(jsonData, JsonRequestBehavior.AllowGet);

        }
    }
}