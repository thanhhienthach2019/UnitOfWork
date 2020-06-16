using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Repository.Interface
{
    public interface IVanBanRepository : IRepositoryBase<vanban>
    {
        Task<IEnumerable<vanban>> GetByPredicate(Expression<Func<vanban, bool>> expression);

        Task<IEnumerable<vanban>> GetAllPar(params Expression<Func<vanban, object>>[] includes);

        Task<IEnumerable<vanban>> GetMultiByPredicate(Expression<Func<vanban, bool>> expression, params Expression<Func<vanban, object>>[] includes);

        Task<vanban> GetSingleByPredicate(Expression<Func<vanban, bool>> expression, params Expression<Func<vanban, object>>[] includes);
    }
}