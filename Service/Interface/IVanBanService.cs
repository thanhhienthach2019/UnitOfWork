using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Service.Interface
{
    public interface IVanBanService
    {
        IEnumerable<VanBanDTO> GetAll();

        VanBanDTO GetById(object id);

        IEnumerable<VanBanDTO> GetByPredicate(Expression<Func<VanBanDTO, bool>> expression);

        VanBanDTO Add(VanBanDTO vanBanDTO);

        VanBanDTO Delete(object id);

        void Update(VanBanDTO vanBanDTO);
    }
}