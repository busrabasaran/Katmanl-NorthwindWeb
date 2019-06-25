using KatmanliNorthwindWeb.BLL;
using KatmanliNorthwindWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliNorthwindWeb.UI.Controllers
{
    public class OrderController : Controller
    {
        OrderBLL orderBLL = new OrderBLL();
        // GET: Order
        public ActionResult OrderIndex()
        {
            Customers customer = Session["Login"] as Customers;
            List<Orders> orders = orderBLL.GetOrders(customer.CustomerID);
            return View(orders);
        }

    }
}