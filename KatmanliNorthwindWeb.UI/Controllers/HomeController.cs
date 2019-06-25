using KatmanliNorthwindWeb.BLL;
using KatmanliNorthwindWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliNorthwindWeb.UI.Controllers
{
    public class HomeController : Controller
    {
    
        public ActionResult Index()
        {
            return View();
        }
    }
}