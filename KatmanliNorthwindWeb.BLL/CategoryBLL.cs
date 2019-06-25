using KatmanliNorthwindWeb.DAL;
using KatmanliNorthwindWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliNorthwindWeb.BLL
{
    public class CategoryBLL
    {
        Repository<Categories> repo = new Repository<Categories>();

        public List<Categories> GetCategories()
        {
            return repo.List();
        }

        public Categories categories(int id)
        {
            return repo.Find(x=> x.CategoryID==id);
        }
    }
}
