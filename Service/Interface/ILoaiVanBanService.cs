using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ILoaiVanBanService
    {
        Task<IEnumerable<LoaiVanBanDTO>> GetAll();

        Task<LoaiVanBanDTO> GetById(object id);

        IEnumerable<LoaiVanBanDTO> GetByPredicate(Expression<Func<LoaiVanBanDTO, bool>> expression);

        LoaiVanBanDTO Add(LoaiVanBanDTO loaiVanBanDTO);

        LoaiVanBanDTO Delete(object id);

        void Update(LoaiVanBanDTO loaiVanBanDTO);
    }
}