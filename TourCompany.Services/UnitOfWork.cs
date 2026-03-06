using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DataAccess.DataAccess;
using TourCompany.DataAccess.Repository;

namespace TourCompany.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TourDBContext _dbContext;
        public IBookingRepository BookingRepository { get; private set; }
        public IExtraRepository ExtraRepository { get; private set; }
        public ITourRepository TourRepository { get; private set; }
        public ICustomerRepository CustomerRepository { get; private set; }

        public ICustomerRepository CustomerRepository { get; private set; }
        
        public UnitOfWork(TourDBContext dbContext)
        {
            _dbContext = dbContext;
            BookingRepository = new BookingRepository(_dbContext);
            ExtraRepository = new ExtraRepository(_dbContext);
            TourRepository = new TourRepository(_dbContext);
            CustomerRepository = new CustomerRepository(_dbContext);
<<<<<<< HEAD

=======
>>>>>>> f019fff7399e40ec9563383755cee9a983ae1d77
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
