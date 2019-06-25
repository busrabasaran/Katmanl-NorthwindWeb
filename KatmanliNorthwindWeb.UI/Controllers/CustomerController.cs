using KatmanliNorthwindWeb.BLL;
using KatmanliNorthwindWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliNorthwindWeb.UI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        CustomerBLL customerBLL = new CustomerBLL();

        public ActionResult CustomerIndex()
        {
            List<Customers> customers = customerBLL.GetCustomers();

            return View(customers);
        }
    }
}