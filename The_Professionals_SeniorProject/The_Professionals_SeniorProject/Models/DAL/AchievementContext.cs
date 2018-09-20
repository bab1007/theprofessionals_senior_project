using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using The_Professionals_SeniorProject.Models.Schema;



namespace The_Professionals_SeniorProject.Models.DAL
{
    public class AchievementContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Accomplishment> Accomplishments { get; set; }


    }
}
