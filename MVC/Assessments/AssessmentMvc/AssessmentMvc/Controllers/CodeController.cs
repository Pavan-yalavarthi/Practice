using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssessmentMvc.Models;

namespace AssessmentMvc.Controllers
{
    public class CodeController : Controller
    {
        private northwindEntities db = new northwindEntities();
       // GET: Code
        public ActionResult Index()
        {
            return View();
        }
       // Customers residing in Germany
        public ActionResult CustomersInGermany()
        {
            var customers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(customers); 
        }

        // Customer details with orderId == 10248
        public ActionResult CustomerOrder()
        {
            var customerDetails = db.Orders
                                     .Where(o => o.OrderID == 10248)
                                     .Select(o => o.Customer)
                                     .FirstOrDefault();
            return View(customerDetails);
        }
    }
}
