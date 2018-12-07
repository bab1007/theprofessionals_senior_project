using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using The_Professionals_SeniorProject.DAL;
using The_Professionals_SeniorProject.Models.Schema;
using The_Professionals_SeniorProject.Models.Viewmodels;

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

        public IActionResult Deny(int id)
        {
            var accomplishment = _context.Accomplishments.FirstOrDefault(a => a.AchievementID == id);
            

            if (ModelState.IsValid)
            {

                _context.Remove(accomplishment);
                _context.SaveChanges();
                return RedirectToAction("Approvals");

            }

            return RedirectToAction("ApprovalView", id);

        }

        public IActionResult EmployeeReport(string noResult)
        {
            var myEmployees = _context.Users.Where(u => u.SupervisorID == 1); // Insert session  Supervisor's Userid here

            if (noResult != null)
            {
                ViewBag.NoResult = noResult;
            }

            return View(myEmployees);
        }

        public IActionResult EmployeeReportResult(int id)
        {
    
           var empAccomplishments = _context.Accomplishments.Where(x => x.UserID == id && x.IsApproved == true);
           var Username = _context.Users.FirstOrDefault(u => u.UserID == id);
            ViewBag.UserName = Username.Fname + " " + Username.Lname;
            
            return View(empAccomplishments);                 
        }

        public IActionResult EmployeeInternalResume(int id)
        {

            var empAccomplishments = _context.Accomplishments.Where(x => x.UserID == id && x.IsApproved == true);
            if(empAccomplishments.Count()!= 0)
            {
                var Username = _context.Users.FirstOrDefault(u => u.UserID == id);


                return new ViewAsPdf(empAccomplishments);
            }
            else
            {
                return RedirectToAction("EmployeeReport", new { noResult = "That employee has no approved accomplishments" });
            }

        }
    }
}