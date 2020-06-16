using Data;
using Repository.Infrastructure.Implement;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Repository.Implement
{
    public class TheLoaiRepository : RepositoryBase<theloai>, ITheLoaiRepository
    {
        public TheLoaiRepository(ISBEntities entities) : base(entities)
        {
        }

        public IEnumerable<theloai> GetByPredicate(Expression<Func<theloai, bool>> expression)
        {
            return _dbSet.AsNoTracking().Where(expression);
        }
    }
}