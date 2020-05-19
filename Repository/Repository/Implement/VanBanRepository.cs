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
    public class VanBanRepository:RepositoryBase<vanban>,IVanBanRepository
    {
        public VanBanRepository(ISBEntities entities):base(entities)
        {

        }

        public IEnumerable<vanban> GetByPredicate(Expression<Func<vanban, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
