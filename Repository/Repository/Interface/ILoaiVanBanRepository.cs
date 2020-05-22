using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Repository.Interface
{
    public interface ILoaiVanBanRepository : IRepositoryBase<loaivanban>
    {
        IEnumerable<loaivanban> GetByPredicate(Expression<Func<loaivanban, bool>> expression);
    }
}