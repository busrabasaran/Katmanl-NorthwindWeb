using KatmanliNorthwindWeb.BLL;
using KatmanliNorthwindWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliNorthwindWeb.UI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        ProductBLL productBLL = new ProductBLL();

        public ActionResult ProductIndex()
        {
            List<Products> products = productBLL.GetProducts();

            return View(products);
        }
    }
}