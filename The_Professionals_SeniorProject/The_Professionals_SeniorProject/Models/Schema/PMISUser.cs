using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using The_Professionals_SeniorProject.Models.Schema;

namespace The_Professionals_SeniorProject.Models.Schema
{
    public class PMISUser
    {
        [Key]
        public int UserID { get; set; }
        public int? SupervisorID { get; set; }

        [Required(ErrorMessage = "Please enter your first name"), MinLength(3), MaxLength(25, ErrorMessage = "This is not a valid first name")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "Please enter your last name"), MinLength(3), MaxLength(25, ErrorMessage = "This is not a valid last name")]
        public string Lname { get; set; }
        [EmailAddress(ErrorMessage = "Must be a valid email address.")]
        [Required(ErrorMessage = "Please enter a valid email"), MinLength(3), MaxLength(75, ErrorMessage = "This is not a valid email")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Must be a valid phone number.")]
        [Required(ErrorMessage = "Please enter a valid phone number with area code"), MinLength(10), MaxLength(11, ErrorMessage = "This is not a valid phone number")]
        public string Phone { get; set; }
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case, lower case , number, and special character")]
        public string Password { get; set; }

        public bool IsSupervisor { get; set; }

        public ICollection<Accomplishment> Accomplishments { get; set; }
        
        
    


    }
}
