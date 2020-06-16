using Data;
using Repository.Infrastructure.Implement;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Repository.Implement
{
    public class LoaiTaiLieuRepository : RepositoryBase<loaitailieu>, ILoaiTaiLieuRepository
    {
        private ISBEntities _iSBEntities;

        public LoaiTaiLieuRepository(ISBEntities iSBEntities) : base(iSBEntities)
        {
            _iSBEntities = iSBEntities;
        }

        public IEnumerable<loaitailieu> GetByPredicate(Expression<Func<loaitailieu, bool>> expression)
        {
            return _dbSet.AsNoTracking().Where(expression);
        }

        public IEnumerable<Get_LoaiTaiLieu_Result> GetLoaiTaiLieu()
        {
            return _iSBEntities.Get_LoaiTaiLieu().ToList();
        }
    }
}