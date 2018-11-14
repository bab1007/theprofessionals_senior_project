using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using The_Professionals_SeniorProject.DAL;
using The_Professionals_SeniorProject.Models.Schema;
using The_Professionals_SeniorProject.Models.Viewmodels;

namespace The_Professionals_SeniorProject.Controllers
{
    public class AccomplishmentsController : Controller
    {
        private readonly AchievementContext _context;

        public AccomplishmentsController(AchievementContext context)
        {
            _context = context;
        }
        public IActionResult Index(AccomplishmentViewModel LVM)
        {
            return View(LVM);
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

        //========== Generate internal Resume based on User Information ================

        public IActionResult InternalResume()
        {
            int user_id = 1; //Change to be the userID obtained through the session variables
            var myAccomplishments = _context.Accomplishments.Where(a => a.UserID == user_id);

            List<Accomplishment> filteredResults = new List<Accomplishment>();
            foreach(var a in myAccomplishments)
            {
                if(a.IsApproved == true)
                {
                    filteredResults.Add(a);
                }
            }

            if(filteredResults.Count() == 0)
            {
                ViewBag.NoResult = "You have no approved accomplishments at this time.";

            }
                                                            
            return View(filteredResults);
           

        }

        //================= List User Accomplishments in a Table ======================================
        public IActionResult MyAccomplishments()
        {
            int user_id = 1; // Change to be the userID obtained through the session variables
            var myAccomplishments = _context.Accomplishments.Where(a => a.UserID == user_id)
                                                            .OrderBy(a => a.AchievementType);

            List<Accomplishment> filteredAccomplishments = new List<Accomplishment>();

            foreach( var a in myAccomplishments)
            {
                if(a.IsApproved == true)
                {
                    filteredAccomplishments.Add(a);
                }
            }

            if(filteredAccomplishments.Count() == 0)
            {
                ViewBag.NoResult = "You Have No Approved Accomplishments At This Time.";
            }

            return View(filteredAccomplishments);
        }

        //================= Export Internal Resume ======================================

            public IActionResult ExportResume()
        {
            int user_id = 1; //Change to be the userID obtained through the session variables
            var myAccomplishments = _context.Accomplishments.Where(a => a.UserID == user_id);

            List<Accomplishment> filteredResults = new List<Accomplishment>();
            foreach (var a in myAccomplishments)
            {
                if (a.IsApproved == true)
                {
                    filteredResults.Add(a);
                }
            }

            if (filteredResults.Count() == 0)
            {
                ViewBag.NoResult = "You have no approved accomplishments at this time.";

            }

            return new ViewAsPdf(filteredResults);
           
        }


        //================= View Accomplishment Details ======================================
        public IActionResult ViewAccomplishment(int id)
        {
            var accomplishment = _context.Accomplishments.FirstOrDefault(a => a.AchievementID == id);

            return View(accomplishment);
        }


    }
}