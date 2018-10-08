using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Professionals_SeniorProject.Models;


namespace The_Professionals_SeniorProject.Controllers
{
   
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }   
     
        public IActionResult CreateAccount()
        {
            ViewData["Message"] = "Please enter your account credentials.";
            return View();
            //ToDo: Build form to correspond with model User.cs


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
