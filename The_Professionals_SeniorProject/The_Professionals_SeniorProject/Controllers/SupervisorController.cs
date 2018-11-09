using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using The_Professionals_SeniorProject.DAL;
using The_Professionals_SeniorProject.Models.Schema;

namespace The_Professionals_SeniorProject.Controllers
{
    public class SupervisorController : Controller
    {
      
        private readonly AchievementContext _context;

        public SupervisorController(AchievementContext context)
        {
            _context = context;
        }
        //=========== Supervisor views approvals where supervisorID == their EmployeeID =========================
        public IActionResult Approvals()
        {
            var myApprovals = _context.Accomplishments.Include(u => u.User)
                                            .Where(a =>a.IsApproved == false).ToList();

            List<Accomplishment> filteredApprovals = new List<Accomplishment>();

            foreach (var i in myApprovals)
            {
                if (i.User.SupervisorID == 1) //Insert SessionID here.;
                {
                    filteredApprovals.Add(i);
                }


            }

            return View(filteredApprovals);
        }

        // ====================== Get Approval details to either approve or deny ================================
        public IActionResult ApprovalView(int id)
        {
            var getRequest = _context.Accomplishments.Include( a => a.User)
                                                     .FirstOrDefault(ac => ac.AchievementID == id);

            return View(getRequest);
        }

        // ====================== Supervisor Updates An employee's Accomplishment Submission ================================
        
        public IActionResult Approve(int id)
        {
            var accomplishment = _context.Accomplishments.FirstOrDefault(a => a.AchievementID == id);
            accomplishment.IsApproved = true;
            accomplishment.DateApproved = DateTime.Now;

            if (ModelState.IsValid){

                _context.Update(accomplishment);
                _context.SaveChanges();
               return RedirectToAction("Approvals");
            
            }

            return RedirectToAction("ApprovalView", id );

        }


        public IActionResult CreateUser()
        {
            return View();
        }

        public IActionResult EmployeeReport()
        {
            var myEmployees = _context.Users.Where(u => u.SupervisorID == 1); // Insert session Userid here

            List<SelectListItem> UserSelectList = new List<SelectListItem>();

            // loop through Users and create select list to pass to view

            foreach (var item in myEmployees)
            {
                SelectListItem newlistitem = new SelectListItem();
                newlistitem.Value = item.UserID.ToString();
                newlistitem.Text = item.Fname + " " + item.Lname;
                UserSelectList.Add(newlistitem);
            }
            //Assign Select Llist to ViewBag
            ViewBag.MyUsers = UserSelectList;

            return View();
        }

        public IActionResult EmployeeReportResult(int id)
        {

            return View();                 
        }
    }
}