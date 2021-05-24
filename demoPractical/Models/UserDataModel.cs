using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoPractical.Models
{
    public class UserDataModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "User Password Is Required!")]
        [StringLength(10, ErrorMessage = "Password Must Be Of 8 Characters!")]
        public string UserPassword { get; set; }
        [Required(ErrorMessage = "User Retype Password Is Required!")]
        [Compare("UserPassword", ErrorMessage ="Password & Retype Password Must Be Same!")]
        public string RetypePassword { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<bool> Gender { get; set; }
        [Required(ErrorMessage = "User Email Is Required!")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter Valid Email Address!!")]
        public string UserEmail { get; set; }
    }
}