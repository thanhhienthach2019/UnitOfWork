using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ITaiLieuService
    {
        Task<IEnumerable<TaiLieuDTO>> GetAll();
        Task<IEnumerable<TaiLieuDTO>> GetAllPar();
        Task<TaiLieuDTO> GetById(object id);
        Task<IEnumerable<TaiLieuDTO>> GetByPredicate(Expression<Func<TaiLieuDTO, bool>> expression);
        Task<IEnumerable<TaiLieuDTO>> GetMultiByPredicate(Expression<Func<TaiLieuDTO, bool>> expression);
        Task<TaiLieuDTO> GetSingleByPredicate(Expression<Func<TaiLieuDTO, bool>> expression);
        TaiLieuDTO Add(TaiLieuDTO taiLieuDTO);
        void Update(TaiLieuDTO taiLieuDTO);
        Task<TaiLieuDTO> Delete(object id);
    }
}