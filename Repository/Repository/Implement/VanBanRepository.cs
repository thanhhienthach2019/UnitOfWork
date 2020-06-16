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
    public class VanBanRepository : RepositoryBase<vanban>, IVanBanRepository
    {
        public VanBanRepository(ISBEntities entities) : base(entities)
        {
        }

        public async Task<IEnumerable<vanban>> GetAllPar(params Expression<Func<vanban, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            query = includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<vanban>> GetByPredicate(Expression<Func<vanban, bool>> expression)
        {
            return await _dbSet.AsNoTracking().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<vanban>> GetMultiByPredicate(Expression<Func<vanban, bool>> expression, params Expression<Func<vanban, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().ToListAsync();
        }

        public async Task<vanban> GetSingleByPredicate(Expression<Func<vanban, bool>> expression, params Expression<Func<vanban, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().FirstOrDefaultAsync();
        }
    }
}