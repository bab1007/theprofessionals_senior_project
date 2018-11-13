using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Professionals_SeniorProject.DAL;
using The_Professionals_SeniorProject.Models.Schema;

namespace The_Professionals_SeniorProject.Controllers
{
    public class AccountSettingsController : Controller
    {
        private readonly AchievementContext _context;

        public AccountSettingsController(AchievementContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var userInfo = _context.Users.FirstOrDefault(u => u.UserID == 1);
            return View(userInfo);
        }

        //===============  Edit account settings information ===========================
        [HttpPost]
        public IActionResult Index(PMISUser user)
        {
            if (ModelState.IsValid)
            {
                _context.Update(user);
                _context.SaveChanges();

                return RedirectToAction("ProfileUpdated");
            }

            return View(user);
        }
        //===============  Edit account settings information ===========================

        public IActionResult ProfileUpdated()
        {
            return View();
        }
    }
}