using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ITheLoaiService
    {
        Task<IEnumerable<TheLoaiDTO>> GetAll();

        Task<TheLoaiDTO> GetById(object id);

        IEnumerable<TheLoaiDTO> GetByPredicate(Expression<Func<TheLoaiDTO, bool>> expression);

        Task<TheLoaiDTO> Add(TheLoaiDTO theLoaiDTO);

        void Update(TheLoaiDTO theLoaiDTO);

        Task<TheLoaiDTO> Delete(object id);
    }
}