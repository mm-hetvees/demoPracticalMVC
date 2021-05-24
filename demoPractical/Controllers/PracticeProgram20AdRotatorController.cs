using demoPractical.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoPractical.Controllers
{
    public class PracticeProgram20AdRotatorController : Controller
    {
        // GET: PracticeProgram20AdRotator
        public ActionResult Index()
        {
                string xmlData = HttpContext.Server.MapPath("~/Models/Product.xml");//Path of the xml script  
                DataSet ds = new DataSet();//Using dataset to read xml file  
                ds.ReadXml(xmlData);
                var products = new List<Product>();
                products = (from rows in ds.Tables[0].AsEnumerable()
                            select new Product
                            {
                                ProductId = Convert.ToInt32(rows[0].ToString()), //Convert row to int  
                                ProductName = rows[1].ToString(),
                                ProductCost = rows[2].ToString(),
                            }).ToList();
            return View("Index", products);
        }
    }
}