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
    public class TaiLieuRepository : RepositoryBase<tailieu>, ITaiLieuRepository
    {
        public TaiLieuRepository(ISBEntities iSBEntities) : base(iSBEntities)
        {
        }

        public async Task<IEnumerable<tailieu>> GetAllPar(params Expression<Func<tailieu, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<tailieu>> GetByPredicate(Expression<Func<tailieu, bool>> expression)
        {
            return await _dbSet.AsNoTracking().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<tailieu>> GetMultiByPredicate(Expression<Func<tailieu, bool>> expression, params Expression<Func<tailieu, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().ToListAsync();
        }

        public async Task<tailieu> GetSingleByPredicate(Expression<Func<tailieu, bool>> expression, params Expression<Func<tailieu, object>>[] includes)
        { 
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().FirstOrDefaultAsync();
        }
    }
}