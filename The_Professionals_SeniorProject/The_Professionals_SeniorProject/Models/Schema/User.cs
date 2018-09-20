using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using The_Professionals_SeniorProject.Models.Schema;




namespace The_Professionals_SeniorProject.Models.Schema
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        //System.ComponentModel.DataAnnotations allows you to decorate model properties with validation info as well as 
        //SQL-like stuff like whether or not a property is a [Key]
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

        //ICollection is an interface to represent a collection of Accomplishments unique to each User
        public ICollection<Accomplishment> Accomplishments { get; set; }

    


    }
}
