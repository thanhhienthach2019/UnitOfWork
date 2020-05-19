using Repository.Repository.Interface;

namespace Repository.Infrastructure.Interface
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IDonviRepository DonViRepository { get; }
        ILoaiVanBanRepository LoaiVanBanRepository { get; }
        IVanBanRepository VanBanRepository { get; }

        void Commit();

        void Dispose(bool disposing);

        void Dispose();
    }
}