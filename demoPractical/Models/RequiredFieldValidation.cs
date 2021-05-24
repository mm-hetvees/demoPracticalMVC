using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoPractical.Models
{
    public class RequiredFieldValidation
    {
        [Required(ErrorMessage ="First Name Is Required!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Is Required!")]
        public string LastName { get; set; }
    }
}