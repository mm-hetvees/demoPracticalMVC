using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoPractical.Models
{
    public class AgeValidator
    {
        [Range(10,20,ErrorMessage ="Please Enter Age Between 10 And 20!")]
        public int age { get; set; }
    }
}