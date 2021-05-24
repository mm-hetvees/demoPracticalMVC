using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoPractical.Models
{
    public class RegexValidator
    {
        //[\w.\-] matches any word character (a-z, A-Z, 0-9, or an underscore), a period, or a hyphen.
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="Please Enter Valid Email Address!!")]
        public string Email { get; set; }
    }
}