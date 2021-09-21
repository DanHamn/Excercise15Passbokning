using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Övning15Passbokning.Core.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {

        //Navigation Proparty
        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}
