using System.Collections.Generic;

namespace Repository.Infrastructure.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(object id);

        TEntity Add(TEntity entity);

        TEntity Delete(object id);

        void Update(TEntity entity);
    }
}