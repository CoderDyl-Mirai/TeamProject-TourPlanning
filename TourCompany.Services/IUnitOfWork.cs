using TourCompany.DataAccess.Repository;

namespace TourCompany.Services
{
    public interface IUnitOfWork : IDisposable
    {
        IBookingRepository BookingRepository { get; }
        IExtraRepository ExtraRepository { get; }
        ITourRepository TourRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        void Save();
    }
}
