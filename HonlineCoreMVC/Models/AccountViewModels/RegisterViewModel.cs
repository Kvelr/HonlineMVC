using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HonlineCoreMVC.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Identity number")]
        public string Taz { get; set; }

        [Required]
        [Display(Name = "Birth date")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name = "Loan Amount")]
        [DisplayFormat(DataFormatString = "₪{0:N4}")]
        public Decimal LoanAmount { get; set; }

        [Required]
        [Display(Name = "Period in mounths")]
        public int PeriodInMonths { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public bool isAdmin { get; set; }
    }
}
