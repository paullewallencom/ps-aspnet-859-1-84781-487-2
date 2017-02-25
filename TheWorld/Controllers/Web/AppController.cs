using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWorld.Services;
using TheWorld.ViewModels;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            //throw new InvalidOperationException("It is only The Strong that Fortuna comes to save.");
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            _mailService.SendMail("paul@aol.com", model.Email, "From TheWorld", model.Message);

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
