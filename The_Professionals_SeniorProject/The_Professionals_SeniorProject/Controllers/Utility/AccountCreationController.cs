using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Professionals_SeniorProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;


namespace The_Professionals_SeniorProject.Controllers.Navigation
{
    public class AccountCreationController
    {
        //Dependency injection of context class to allow controller to access the Dbset properties inside of the context class
        private readonly AchievementContext _context;

        public AccountCreationController(AchievementContext context)
        {
            _context = context;

        }
       

    }
}
