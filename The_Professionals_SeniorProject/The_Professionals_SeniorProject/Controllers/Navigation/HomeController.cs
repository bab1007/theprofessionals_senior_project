using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Professionals_SeniorProject.Models;
using The_Professionals_SeniorProject.DAL;
using The_Professionals_SeniorProject.Models.Viewmodels;


namespace The_Professionals_SeniorProject.Controllers
{
    
   
    public class HomeController : Controller
    {
        private AchievementContext _context;

        public HomeController(AchievementContext context)

        {
            _context = context;
        }
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
        [HttpPost]
        public IActionResult ValidUserRedirect(string Email, string Password)
        {
            

            var userquery = from u in _context.Users
                            where u.Email == Email
                            where u.Password == Password
                            select u;
            LoginViewModel LVM = new LoginViewModel();


            if (userquery.ToList().Count == 1)
            {
               
                foreach (var user in userquery)
                {
                    LVM.UserName = user.Fname + " " + user.Lname;
                    LVM.UserEmail = user.Email;
                    LVM.UserAccomplishments = user.Accomplishments;
                    
                    
                }
                return RedirectToAction("Index", "Accomplishments", LVM);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
