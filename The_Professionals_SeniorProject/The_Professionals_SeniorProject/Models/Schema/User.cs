using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;




namespace The_Professionals_SeniorProject.Models.Schema
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please enter your first name"), MinLength(3), MaxLength(25, ErrorMessage = "This is not a valid first name")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "Please enter your last name"), MinLength(3), MaxLength(25, ErrorMessage = "This is not a valid last name")]
        public string Lname { get; set; }
        [Required(ErrorMessage = "Please enter a valid email"), MinLength(3), MaxLength(75, ErrorMessage = "This is not a valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a valid phone number with area code"), MinLength(10), MaxLength(11, ErrorMessage = "This is not a valid phone number")]
        public string Phone { get; set; }
        
        public string Password { get; set; }

        public bool IsSupervisor { get; set; }


    }
}
