using Data;
using Repository.Infrastructure.Implement;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Repository.Implement
{
    public class LoaiVanBanRepository : RepositoryBase<loaivanban>, ILoaiVanBanRepository
    {
        public LoaiVanBanRepository(ISBEntities entities) : base(entities)
        {
        }

        public IEnumerable<loaivanban> GetByPredicate(Expression<Func<loaivanban, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}