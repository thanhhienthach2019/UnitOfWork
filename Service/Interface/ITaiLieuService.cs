using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ITaiLieuService
    {
        IEnumerable<TaiLieuDTO> GetAll();
        TaiLieuDTO GetById(object id);
        IEnumerable<TaiLieuDTO> GetByPredicate(Expression<Func<TaiLieuDTO, bool>> expression);
        TaiLieuDTO Add(TaiLieuDTO taiLieuDTO);
        void Update(TaiLieuDTO taiLieuDTO);
        TaiLieuDTO Delete(object id);
    }
}
