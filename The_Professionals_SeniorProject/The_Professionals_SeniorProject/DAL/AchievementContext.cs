using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using The_Professionals_SeniorProject.Models.Schema;



namespace The_Professionals_SeniorProject.DAL
{
    public class AchievementContext : DbContext
    {
        public AchievementContext(DbContextOptions<AchievementContext> options) : base(options) { }

        public virtual DbSet<PMISUser> Users { get; set; }

        public virtual DbSet<Accomplishment> Accomplishments { get; set; }


    }
}
