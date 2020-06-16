using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IBanHanhVbService
    {
        Task<IEnumerable<BanhanhvbDTO>> GetAll();

        Task<IEnumerable<BanhanhvbDTO>> GetAllPar();

        Task<BanhanhvbDTO> GetById(object id);

        Task<IEnumerable<BanhanhvbDTO>> GetByPredicate(Expression<Func<BanhanhvbDTO, bool>> expression);

        Task<IEnumerable<BanhanhvbDTO>> GetMultiPredicate(Expression<Func<BanhanhvbDTO, bool>> expression);

        Task<BanhanhvbDTO> GetSinglePredicate(Expression<Func<BanhanhvbDTO, bool>> expression);

        Task<BanhanhvbDTO> Add(BanhanhvbDTO banhanhvbDTO);

        void Update(BanhanhvbDTO banhanhvbDTO);

        Task<BanhanhvbDTO> Delete(object id);
    }
}