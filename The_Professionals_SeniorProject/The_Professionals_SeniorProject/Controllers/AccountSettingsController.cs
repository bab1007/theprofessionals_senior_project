﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace The_Professionals_SeniorProject.Controllers
{
    public class AccountSettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}