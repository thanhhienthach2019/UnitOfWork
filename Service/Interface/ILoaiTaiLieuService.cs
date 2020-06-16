using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ILoaiTaiLieuService
    {
        Task<IEnumerable<LoaiTaiLieuDTO>> GetAll();

        Task<LoaiTaiLieuDTO> GetById(object id);

        IEnumerable<LoaiTaiLieuDTO> GetByPredicate(Expression<Func<LoaiTaiLieuDTO, bool>> expression);

        LoaiTaiLieuDTO Add(LoaiTaiLieuDTO loaiTaiLieuDTO);

        void Update(LoaiTaiLieuDTO loaiTaiLieuDTO);

        LoaiTaiLieuDTO Delete(object id);

        IEnumerable<GetLoaiTaiLieuDTO> GetLoaiTaiLieu();
    }
}