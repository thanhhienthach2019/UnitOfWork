using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Repository.Interface
{
    public interface ITaiLieuRepository : IRepositoryBase<tailieu>
    {
        Task<IEnumerable<tailieu>> GetByPredicate(Expression<Func<tailieu, bool>> expression);

        Task<IEnumerable<tailieu>> GetAllPar(params Expression<Func<tailieu, object>>[] includes);

        Task<IEnumerable<tailieu>> GetMultiByPredicate(Expression<Func<tailieu, bool>> expression, params Expression<Func<tailieu, object>>[] includes);

        Task<tailieu> GetSingleByPredicate(Expression<Func<tailieu, bool>> expression, params Expression<Func<tailieu, object>>[] includes);
    }
}