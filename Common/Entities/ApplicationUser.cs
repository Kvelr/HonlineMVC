using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HonlineCoreMVC.Common.Entities
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Taz { get; set; }
        public DateTime BirthDate { get; set; }
        public Decimal LoanAmount { get; set; }
        public int PeriodInMonths { get; set; }
    }
}
