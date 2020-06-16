using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Repository.Interface
{
    public interface ILoaiTaiLieuRepository : IRepositoryBase<loaitailieu>
    {
        IEnumerable<loaitailieu> GetByPredicate(Expression<Func<loaitailieu, bool>> expression);

        IEnumerable<Get_LoaiTaiLieu_Result> GetLoaiTaiLieu();
    }
}