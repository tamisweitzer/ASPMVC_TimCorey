using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPMVCDataAccess.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Range(100000, 999999, ErrorMessage="Enter a 6-digit ID")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter a first name")] 
        public string FirstName { get; set; }
       
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter a last name")] 
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Enter an email address")]
        public string EmailAddress { get; set; }
        
        [Display(Name = "Confirm Email Address")]
        [Compare("EmailAddress", ErrorMessage = "The emails entered do not match")]
        public string ConfirmEmailAddress { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Enter a password with a minimum of 8 characters and a maximum of 20")]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}