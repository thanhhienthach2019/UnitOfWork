using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Repository.Interface
{
    public interface IBanHanhVbRepository : IRepositoryBase<Banhanhvb>
    {
        Task<IEnumerable<Banhanhvb>> GetByPredicate(Expression<Func<Banhanhvb, bool>> expression);

        Task<IEnumerable<Banhanhvb>> GetAllPar(params Expression<Func<Banhanhvb, object>>[] includes);

        Task<IEnumerable<Banhanhvb>> GetByMultiPredicate(Expression<Func<Banhanhvb, bool>> expression, params Expression<Func<Banhanhvb, object>>[] includes);

        Task<Banhanhvb> GetSinglePredicate(Expression<Func<Banhanhvb, bool>> expression, params Expression<Func<Banhanhvb, object>>[] includes);
    }
}