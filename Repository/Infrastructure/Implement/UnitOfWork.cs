using Data;
using Repository.Infrastructure.Interface;
using Repository.Repository.Implement;
using Repository.Repository.Interface;
using System;

namespace Repository.Infrastructure.Implement
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository UserRepository { get; private set; }
        public IDonviRepository DonViRepository { get; private set; }
        public ILoaiVanBanRepository LoaiVanBanRepository { get; private set; }
        public IVanBanRepository VanBanRepository { get; private set; }

        private ISBEntities _dbContext;
        private bool disposed;

        public UnitOfWork(ISBEntities dbContext)
        {
            _dbContext = dbContext;
            UserRepository = new UserRepository(_dbContext);
            DonViRepository = new DonviRepository(_dbContext);
            LoaiVanBanRepository = new LoaiVanBanRepository(_dbContext);
            VanBanRepository = new VanBanRepository(_dbContext);
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
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

        ~UnitOfWork()
        {
            Dispose();
        }
    }
}