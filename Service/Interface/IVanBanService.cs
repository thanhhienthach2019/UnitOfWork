using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
