using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Professionals_SeniorProject.Models.Schema;


namespace The_Professionals_SeniorProject.Models.Viewmodels
{
    public class LoginViewModel
    {
       public string UserEmail { get; set; }

       public string UserName { get; set; }

       public ICollection<Accomplishment> UserAccomplishments { get; set; }


       public LoginViewModel()
        {
            this.UserAccomplishments = new List<Accomplishment>();

        }
    }
}
