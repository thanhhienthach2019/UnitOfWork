using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Service.Interface
{
    public interface ILoaiVanBanService
    {
        IEnumerable<LoaiVanBanDTO> GetAll();

        LoaiVanBanDTO GetById(object id);

        IEnumerable<LoaiVanBanDTO> GetByPredicate(Expression<Func<LoaiVanBanDTO, bool>> expression);

        LoaiVanBanDTO Add(LoaiVanBanDTO loaiVanBanDTO);

        LoaiVanBanDTO Delete(object id);

        void Update(LoaiVanBanDTO loaiVanBanDTO);
    }
}