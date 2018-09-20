using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using The_Professionals_SeniorProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace The_Professionals_SeniorProject.Controllers.Utility
{
    public class LoginController
    {
        private readonly AchievementContext _context;

        public LoginController(AchievementContext context)
        {
            _context = context;

        }

    }
}
