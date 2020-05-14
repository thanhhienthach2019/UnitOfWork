using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Service.Interface
{
    public interface IDonViService
    {
        IEnumerable<DonViDTO> GetAll();

        DonViDTO GetByID(object id);

        IEnumerable<DonViDTO> GetByPredicate(Expression<Func<DonViDTO, bool>> predicate);

        DonViDTO Add(DonViDTO donViDTO);

        DonViDTO Delete(object id);

        void Update(DonViDTO donViDTO);
    }
}