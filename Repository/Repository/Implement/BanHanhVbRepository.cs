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
    public class BanHanhVbRepository : RepositoryBase<Banhanhvb>, IBanHanhVbRepository
    {
        public BanHanhVbRepository(ISBEntities entities) : base(entities)
        {
        }

        public async Task<IEnumerable<Banhanhvb>> GetAllPar(params Expression<Func<Banhanhvb, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Banhanhvb>> GetByMultiPredicate(Expression<Func<Banhanhvb, bool>> expression, params Expression<Func<Banhanhvb, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Banhanhvb>> GetByPredicate(Expression<Func<Banhanhvb, bool>> expression)
        {
            return await _dbSet.AsNoTracking().Where(expression).ToListAsync(); ;
        }

        public async Task<Banhanhvb> GetSinglePredicate(Expression<Func<Banhanhvb, bool>> expression, params Expression<Func<Banhanhvb, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().FirstOrDefaultAsync();
        }
    }
}