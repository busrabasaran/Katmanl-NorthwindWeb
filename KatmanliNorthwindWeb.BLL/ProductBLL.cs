using KatmanliNorthwindWeb.DAL;
using KatmanliNorthwindWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliNorthwindWeb.BLL
{
    public class ProductBLL
    {
        Repository<Products> repo = new Repository<Products>();

        public List<Products> GetProducts()
        {
            return repo.List();
        }
    }
}
