using Data;
using Repository.Infrastructure.Implement;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Implement
{
    public class UserRepository : RepositoryBase<user>, IUserRepository
    {
        public UserRepository(ISBEntities entities) : base(entities)
        {
        }
        public user GetByPredicate(Expression<Func<user, bool>> condition)
        {
            return _dbSet.Where(condition).FirstOrDefault();
        }
    }
}
