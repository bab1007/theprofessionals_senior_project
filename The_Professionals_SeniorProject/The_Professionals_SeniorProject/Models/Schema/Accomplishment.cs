﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Professionals_SeniorProject.Models.Schema;
using System.ComponentModel.DataAnnotations;

namespace The_Professionals_SeniorProject.Models.Schema
{
    public class Accomplishment
    {
        [Key]
        public int AchievementID { get; set; }
        
        public int UserID { get; set; }

        public virtual User User { get; }

        public string Provider { get; set; }

        public string Activity { get; set; }

        public string Description { get; set; }

        public string JobTitle { get; set; }

        public string BookTitle { get; set; }

        public string Author { get; set; }

        public string AchievementType { get; set; }

        public DateTime DateStarted { get; set; }

        public DateTime DateCompleted { get; set; }

        public string URL { get; set; }

        public string ContactPerson { get; set; }

        public string ContactPhone { get; set; }

        public string ContactEmail { get; set; }

        public DateTime DateApproved { get; set; }

        public bool IsApproved { get; set; }


        
        
        
    }
}