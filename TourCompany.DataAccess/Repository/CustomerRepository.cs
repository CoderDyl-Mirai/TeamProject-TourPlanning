using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> f019fff7399e40ec9563383755cee9a983ae1d77
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
<<<<<<< HEAD
=======

        public Customer Get(string s)
        {
            if (s == "")
                return null;
            else
                return _dBContext.Customers.Where(u => u.Id == s).FirstOrDefault();
        }
>>>>>>> f019fff7399e40ec9563383755cee9a983ae1d77
    }
}
