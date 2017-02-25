using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            //throw new InvalidOperationException("It is only The Strong that Fortuna comes to save.");
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
