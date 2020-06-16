using Data;
using Repository.Infrastructure.Implement;
using Repository.Repository.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Repository.Implement
{
    public class UserRepository : RepositoryBase<user>, IUserRepository
    {
        public UserRepository(ISBEntities entities) : base(entities)
        {
        }

        public async Task<IEnumerable<user>> GetAllPar(params Expression<Func<user, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<user>> GetByMultiByPredicate(Expression<Func<user, bool>> expression, params Expression<Func<user, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<user>> GetByPredicate(Expression<Func<user, bool>> condition)
        {
            return await _dbSet.AsNoTracking().Where(condition).ToListAsync();
        }

        public async Task<user> GetSingleByPredicate(Expression<Func<user, bool>> expression, params Expression<Func<user, object>>[] includes)
        {
            var query = _dbSet.AsQueryable();
            return await includes.Aggregate(query, (curren, includeProperty) => curren.Include(includeProperty)).AsNoTracking().FirstOrDefaultAsync();
        }
    }
}