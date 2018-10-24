using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace The_Professionals_SeniorProject.Controllers
{
    public class SupervisorController : Controller
    {
        public IActionResult Approvals()
        {
            return View();
        }

        public IActionResult ApprovalView()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        public IActionResult EmployeeReport()
        {
            return View();
        }

        public IActionResult EmployeeReportResult()
        {
            return View();
        }
    }
}