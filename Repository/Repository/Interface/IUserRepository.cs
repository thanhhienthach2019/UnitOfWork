using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Repository.Interface
{
    public interface IUserRepository : IRepositoryBase<user>
    {
        Task<IEnumerable<user>> GetByPredicate(Expression<Func<user, bool>> expression);
        Task<IEnumerable<user>> GetAllPar(params Expression<Func<user,object>>[] includes);
        Task<IEnumerable<user>> GetByMultiByPredicate(Expression<Func<user, bool>> expression, params Expression<Func<user, object>>[] includes);
        Task<user> GetSingleByPredicate(Expression<Func<user, bool>> expression, params Expression<Func<user, object>>[] includes);
    }
}