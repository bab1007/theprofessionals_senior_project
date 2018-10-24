using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace The_Professionals_SeniorProject.Controllers
{
    public class AccomplishmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    

        public IActionResult SubmitAccomplishment()
        {
            return View();
        }

        public IActionResult MediaForm ()
        {
            return View();
        }

        public IActionResult ReadForm()
        {
            return View();
        }

        public IActionResult WorkForm()
        {
            return View();
        }

        public IActionResult CourseForm()
        {
            return View();
        }

        public IActionResult InternalResume()
        {
            return View();
        }


        public IActionResult MyAccomplishments()
        {
            return View();
        }

        public IActionResult ViewAccomplishment()
        {
            return View();
        }


    }
}