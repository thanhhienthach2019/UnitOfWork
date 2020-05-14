using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Data;
using Repository.Infrastructure.Implement;
using Repository.Repository.Interface;

namespace Repository.Repository.Implement
{
    public class DonviRepository : RepositoryBase<DonVi>, IDonviRepository
    {
        public DonviRepository(ISBEntities entities) : base(entities)
        {
        }

        public IEnumerable<DonVi> GetByPredicate(Expression<Func<DonVi, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}