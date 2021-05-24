using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoPractical.Models
{
    public class CompareValidator
    {
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password & Confirm Password Must Be Same!!")]
        public string ConfirmPassword { get; set; }
    }
}