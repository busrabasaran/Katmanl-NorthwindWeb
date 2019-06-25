using KatmanliNorthwindWeb.BLL;
using KatmanliNorthwindWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliNorthwindWeb.UI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        CategoryBLL categoryBLL = new CategoryBLL();

        public ActionResult CategoryIndex()
        {
            List<Categories> categories = categoryBLL.GetCategories();

            return View(categories);
        }
    }
}