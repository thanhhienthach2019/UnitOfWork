using Repository.Repository.Interface;
using System.Threading.Tasks;

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
        IBanHanhVbRepository BanHanhVbRepository { get; }
        ITheLoaiRepository TheLoaiRepository { get; }
        ILoaiTinRepository LoaiTinRepository { get; }

        void Commit();

        Task CommitAsync();

        void Dispose(bool disposing);

        void Dispose();
    }
}