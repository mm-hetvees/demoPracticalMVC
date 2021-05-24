using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demoPractical.Models
{
    public class EmployeeDepartmentData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<long> Salary { get; set; }
        public Nullable<long> Commision { get; set; }
        public string DepartmentName { get; set; }
        //public int PageCount { get; set; }
        //public int PageNumber { get; set; }
    }
}