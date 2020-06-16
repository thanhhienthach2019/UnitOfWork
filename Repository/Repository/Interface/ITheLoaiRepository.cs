using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Repository.Interface
{
    public interface ITheLoaiRepository : IRepositoryBase<theloai>
    {
        IEnumerable<theloai> GetByPredicate(Expression<Func<theloai, bool>> expression);
    }
}