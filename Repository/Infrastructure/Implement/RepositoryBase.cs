using Data;
using Repository.Infrastructure.Interface;
using System.Collections.Generic;
using System.Data.Entity;

namespace Repository.Infrastructure.Implement
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private ISBEntities _dbContext;
        protected DbSet<TEntity> _dbSet;

        public RepositoryBase(ISBEntities dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        public TEntity Delete(object id)
        {
            TEntity entity = _dbSet.Find(id);
            return _dbSet.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}