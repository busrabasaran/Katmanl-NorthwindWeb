using KatmanliNorthwindWeb.DAL;
using KatmanliNorthwindWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliNorthwindWeb.BLL
{
    public class CustomerBLL
    {
        Repository<Customers> repo = new Repository<Customers>();

        public List<Customers> GetCustomers()
        {
            return repo.List();
        }

        public Customers GetCustomer(string id)
        {
            return repo.Find(x => x.CustomerID == id);
        }
    }
}
