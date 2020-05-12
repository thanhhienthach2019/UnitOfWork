using Repository.Repository.Implement;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Interface
{
    public interface IUnitOfWork
    {
        UserRepository UserRepository { get; }
        DonviRepository DonViRepository { get; }
        void Commit();
        void Dispose(bool disposing);
        void Dispose();
    }
}
