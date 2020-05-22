using Repository.Repository.Interface;

namespace Repository.Infrastructure.Interface
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IDonviRepository DonViRepository { get; }
        ILoaiVanBanRepository LoaiVanBanRepository { get; }
        IVanBanRepository VanBanRepository { get; }
        ILoaiTaiLieuRepository LoaiTaiLieuRepository { get; }
        ITaiLieuRepository TaiLieuRepository { get; }

        void Commit();

        void Dispose(bool disposing);

        void Dispose();
    }
}