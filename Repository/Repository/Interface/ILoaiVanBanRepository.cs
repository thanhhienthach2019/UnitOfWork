using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Interface
{
    public interface ILoaiVanBanRepository:IRepositoryBase<loaivanban>
    {
        IEnumerable<loaivanban> GetByPredicate(Expression<Func<loaivanban, bool>> expression);
    }
}
