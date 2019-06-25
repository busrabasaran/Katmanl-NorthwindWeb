using KatmanliNorthwindWeb.DAL;
using KatmanliNorthwindWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliNorthwindWeb.BLL
{
    public class OrderBLL
    {
        Repository<Orders> repo = new Repository<Orders>();

        public List<Orders> GetOrders()
        {
            return repo.List();
        }

        public List<Orders> GetOrders(string id)
        {
            return repo.List(x => x.CustomerID == id);
        }
    }
}
