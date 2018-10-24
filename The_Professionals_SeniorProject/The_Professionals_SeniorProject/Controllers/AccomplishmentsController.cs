using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Professionals_SeniorProject.DAL;
using The_Professionals_SeniorProject.Models.Schema;

namespace The_Professionals_SeniorProject.Controllers
{
    public class AccomplishmentsController : Controller
    {
        private readonly AchievementContext _context;

        public AccomplishmentsController(AchievementContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    

        public IActionResult SubmitAccomplishment()
        {
            return View();
        }
        // ================== Media Get & Post ==========================

        public IActionResult MediaForm ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MediaForm(Accomplishment accomplishment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accomplishment);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(accomplishment);
        }
        //=================== Read GET & POST ==========================

        public IActionResult ReadForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ReadForm(Accomplishment accomplishment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accomplishment);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(accomplishment);
        }

        //===================== Read GET & POST ===================== 

        public IActionResult WorkForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WorkForm(Accomplishment accomplishment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accomplishment);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(accomplishment);
        }

        //===================== Course GET & POST =======================

        public IActionResult CourseForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CourseForm(Accomplishment accomplishment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accomplishment);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(accomplishment);
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