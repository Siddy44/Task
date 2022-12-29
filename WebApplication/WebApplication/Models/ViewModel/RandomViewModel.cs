using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Models.ViewModel
{
    public class RandomViewModel
    {
        public Movies Movie { get; set; }
        public List<Customer> customers { get; set; }
        public string data { get; set; }
    }
}