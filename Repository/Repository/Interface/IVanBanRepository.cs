using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Repository.Interface
{
    public interface IVanBanRepository : IRepositoryBase<vanban>
    {
        IEnumerable<vanban> GetByPredicate(Expression<Func<vanban, bool>> expression);
    }
}