using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
