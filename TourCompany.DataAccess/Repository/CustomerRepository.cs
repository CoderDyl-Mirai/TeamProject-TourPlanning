using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Models.Models;

namespace TourCompany.DataAccess.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly TourDBContext _dBContext;
        public CustomerRepository(TourDBContext dbContext) : base(dbContext)
        {
            _dBContext = dbContext;
        }

        public Customer Get(string s)
        {
            if (s == "")
                return null;
            else
                return _dBContext.Customers.Where(u => u.Id == s).FirstOrDefault();
        }
    }
}
