using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Repository.Interface
{
    public interface IUserRepository : IRepositoryBase<user>
    {
        IEnumerable<user> GetByPredicate(Expression<Func<user, bool>> condition);
    }
}