using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Repository.Interface
{
    public interface IDonviRepository : IRepositoryBase<DonVi>
    {
        IEnumerable<DonVi> GetByPredicate(Expression<Func<DonVi, bool>> expression); 
    }
}