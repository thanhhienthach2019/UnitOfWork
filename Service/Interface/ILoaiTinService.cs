using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ILoaiTinService
    {
        Task<IEnumerable<LoaiTinDTO>> GetAll();

        Task<IEnumerable<LoaiTinDTO>> GetAllPar();

        Task<LoaiTinDTO> GetById(object id);

        IEnumerable<LoaiTinDTO> GetByPredicate(Expression<Func<LoaiTinDTO, bool>> expression);

        Task<IEnumerable<LoaiTinDTO>> GetMultiByPredicate(Expression<Func<LoaiTinDTO, bool>> expression);

        Task<LoaiTinDTO> GetSingleByPredicate(Expression<Func<LoaiTinDTO, bool>> expression);

        Task<LoaiTinDTO> Add(LoaiTinDTO loaiTinDTO);

        void Update(LoaiTinDTO loaiTinDTO);

        Task<LoaiTinDTO> Delete(object id);
    }
}