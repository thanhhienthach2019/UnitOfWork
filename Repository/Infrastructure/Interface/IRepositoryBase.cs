using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Interface
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> GetById(object id);

        TEntity Add(TEntity entity);

        TEntity Delete(object id);

        void Update(TEntity entity);
    }
}