using Data;
using Repository.Infrastructure.Interface;
using Repository.Repository.Implement;
using Repository.Repository.Interface;
using System;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Implement
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository UserRepository { get; private set; }
        public IDonviRepository DonViRepository { get; private set; }
        public ILoaiVanBanRepository LoaiVanBanRepository { get; private set; }
        public IVanBanRepository VanBanRepository { get; private set; }
        public ILoaiTaiLieuRepository LoaiTaiLieuRepository { get; private set; }
        public ITaiLieuRepository TaiLieuRepository { get; private set; }
        public IBanHanhVbRepository BanHanhVbRepository { get; private set; }
        public ITheLoaiRepository TheLoaiRepository { get; private set; }
        public ILoaiTinRepository LoaiTinRepository { get; private set; }

        private ISBEntities _dbContext;
        private bool disposed;
        //private readonly bool _readOnly;

        public UnitOfWork(ISBEntities dbContext/*, bool readOnly = false*/)
        {
            _dbContext = dbContext;
            //_readOnly = readOnly;
            UserRepository = new UserRepository(_dbContext);
            DonViRepository = new DonviRepository(_dbContext);
            LoaiVanBanRepository = new LoaiVanBanRepository(_dbContext);
            VanBanRepository = new VanBanRepository(_dbContext);
            LoaiTaiLieuRepository = new LoaiTaiLieuRepository(_dbContext);
            TaiLieuRepository = new TaiLieuRepository(_dbContext);
            BanHanhVbRepository = new BanHanhVbRepository(_dbContext);
            TheLoaiRepository = new TheLoaiRepository(_dbContext);
            LoaiTinRepository = new LoaiTinRepository(_dbContext);
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //internal bool ReadOnly
        //{
        //    get
        //    {
        //        return _readOnly;
        //    }
        //}

        ~UnitOfWork()
        {
            Dispose();
        }
    }
}