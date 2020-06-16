using Data;
using Repository.Infrastructure.Implement;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Repository.Implement
{
    public class DonviRepository : RepositoryBase<DonVi>, IDonviRepository
    {
        public DonviRepository(ISBEntities entities) : base(entities)
        {
        }

        public IEnumerable<DonVi> GetByPredicate(Expression<Func<DonVi, bool>> expression)
        {
            return _dbSet.AsNoTracking().Where(expression);
        }

        public async Task<IEnumerable<DonVi>> GetAllPar(params Expression<Func<DonVi, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().ToListAsync();
        }
    }
}