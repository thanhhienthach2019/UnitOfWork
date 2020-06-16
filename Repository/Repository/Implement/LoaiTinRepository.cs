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
    public class LoaiTinRepository : RepositoryBase<loaitin>, ILoaiTinRepository
    {
        public LoaiTinRepository(ISBEntities entities) : base(entities)
        {
        }

        public async Task<IEnumerable<loaitin>> GetAllPar(params Expression<Func<loaitin, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            query = includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.AsNoTracking().ToListAsync();
        }

        public IEnumerable<loaitin> GetByPredicate(Expression<Func<loaitin, bool>> expression)
        {
            return _dbSet.AsNoTracking().Where(expression);
        }

        public async Task<IEnumerable<loaitin>> GetMultiByPredicate(Expression<Func<loaitin, bool>> condition, params Expression<Func<loaitin, object>>[] includes)
        {
            var query = _dbSet.Where(condition).AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().ToListAsync();
        }

        public async Task<loaitin> GetSingleByPredicate(Expression<Func<loaitin, bool>> condition, params Expression<Func<loaitin, object>>[] includes)
        {
            var query = _dbSet.Where(condition).AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).FirstOrDefaultAsync();
        }
    }
}