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
    public class TaiLieuRepository : RepositoryBase<tailieu>, ITaiLieuRepository
    {
        public TaiLieuRepository(ISBEntities iSBEntities):base(iSBEntities)
        {

        }
        public IEnumerable<tailieu> GetByPredicate(Expression<Func<tailieu, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
