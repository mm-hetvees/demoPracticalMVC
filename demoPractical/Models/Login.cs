using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoPractical.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Please Enter UserName!!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password!!")]
        public string Password { get; set; }
    }
}