using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoPractical.Models
{
    public class RegisterationWithValidation
    {
        [Required(ErrorMessage = "First Name Is Required!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Is Required!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Age Is Required!")]
        [Range(10, 20, ErrorMessage = "Please Enter Age Between 10 And 20!")]
        public int age { get; set; }
        [Required(ErrorMessage = "Password Is Required!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password Is Required!")]
        [Compare("Password", ErrorMessage = "Password & Confirm Password Must Be Same!!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email Is Required!")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter Valid Email Address!!")]
        public string Email { get; set; }
    }
}