using KatmanliNorthwindWeb.BLL;
using KatmanliNorthwindWeb.Entity;
using KatmanliNorthwindWeb.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliNorthwindWeb.UI.Controllers
{
    public class LoginController : Controller
    {
        CustomerBLL customerBLL = new CustomerBLL();
        public ActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginIndex(LoginModel model)
        {
            Customers customer = customerBLL.GetCustomer(model.CustomerID);

            Session["Login"] = customer;

            return RedirectToAction("OrderIndex","Order");
        }
    }
}