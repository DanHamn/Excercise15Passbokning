using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Övning15Passbokning.Core.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get { return FirstName + " " + LastName; } }
        public DateTime TimeOfRegistration { get; set; }

        //Navigation Proparty
        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}
