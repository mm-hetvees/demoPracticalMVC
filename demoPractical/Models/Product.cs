using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace demoPractical.Models
{
    
    public class Product
    {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductCost { get; set; }
    }
}