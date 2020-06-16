using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IDonViService
    {
        Task<IEnumerable<DonViDTO>> GetAll();

        Task<DonViDTO> GetByID(object id);

        Task<IEnumerable<DonViDTO>> GetAllPar();

        IEnumerable<DonViDTO> GetByPredicate(Expression<Func<DonViDTO, bool>> predicate);

        Task<DonViDTO> Add(DonViDTO donViDTO);

        Task<DonViDTO> Delete(object id);

        void Update(DonViDTO donViDTO);
    }
}