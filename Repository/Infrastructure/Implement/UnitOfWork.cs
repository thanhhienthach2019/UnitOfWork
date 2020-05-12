using Data;
using Repository.Infrastructure.Interface;
using Repository.Repository.Implement;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Implement
{
    public class UnitOfWork : IUnitOfWork
    {
        public UserRepository UserRepository { get; private set; }
        public DonviRepository DonViRepository { get; private set; }
        private ISBEntities _dbContext;
        private bool disposed;
        public void Commit(ISBEntities dbContext)
        {
            _dbContext = dbContext;
            UserRepository = new UserRepository(_dbContext);
            DonViRepository = new DonviRepository(_dbContext);
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
