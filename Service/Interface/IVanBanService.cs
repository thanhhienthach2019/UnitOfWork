using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IVanBanService
    {
        Task<IEnumerable<VanBanDTO>> GetAll();

        Task<IEnumerable<VanBanDTO>> GetAllPar();

        Task<VanBanDTO> GetById(object id);

        Task<IEnumerable<VanBanDTO>> GetByPredicate(Expression<Func<VanBanDTO, bool>> expression);

        Task<IEnumerable<VanBanDTO>> GetMultiByPredicate(Expression<Func<VanBanDTO, bool>> expression);

        Task<VanBanDTO> GetSingleByPredicate(Expression<Func<VanBanDTO, bool>> expression);

        VanBanDTO Add(VanBanDTO vanBanDTO);

        VanBanDTO Delete(object id);

        void Update(VanBanDTO vanBanDTO);
    }
}