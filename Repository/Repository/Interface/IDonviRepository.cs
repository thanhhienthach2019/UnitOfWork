using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Repository.Interface
{
    public interface IDonviRepository : IRepositoryBase<DonVi>
    {
        IEnumerable<DonVi> GetByPredicate(Expression<Func<DonVi, bool>> expression);

        Task<IEnumerable<DonVi>> GetAllPar(params Expression<Func<DonVi, object>>[] includes);
    }
}