using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Repository.Interface
{
    public interface ILoaiTinRepository : IRepositoryBase<loaitin>
    {
        IEnumerable<loaitin> GetByPredicate(Expression<Func<loaitin, bool>> expression);

        Task<IEnumerable<loaitin>> GetAllPar(params Expression<Func<loaitin, object>>[] includes);

        Task<IEnumerable<loaitin>> GetMultiByPredicate(Expression<Func<loaitin, bool>> condition, params Expression<Func<loaitin, object>>[] includes);

        Task<loaitin> GetSingleByPredicate(Expression<Func<loaitin, bool>> condition, params Expression<Func<loaitin, object>>[] includes);
    }
}