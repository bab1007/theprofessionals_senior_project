using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Professionals_SeniorProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using The_Professionals_SeniorProject.Models.Schema;


namespace The_Professionals_SeniorProject.Controllers.Navigation
{
    public class AccountCreationController : Controller
    {
        //Dependency injection of context class to allow controller to access the Dbset properties inside of the context class
        private readonly AchievementContext _context;

        public AccountCreationController(AchievementContext context)
        {
            _context = context;

        }
      

    }
}
