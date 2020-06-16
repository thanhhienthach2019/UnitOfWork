using DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAll();
        Task<IEnumerable<UserDTO>> GetAllPar();
        Task<UserDTO> GetByID(object id);
        Task<IEnumerable<UserDTO>> GetByPredicate(Expression<Func<UserDTO, bool>> predicate);
        Task<IEnumerable<UserDTO>> GetMultiByPredicate(Expression<Func<UserDTO, bool>> expression);
        Task<UserDTO> GetSingleByPredicate(Expression<Func<UserDTO, bool>> expression);
        Task<UserDTO> Add(UserDTO userDTO);
        Task<UserDTO> Delete(object id);
        void Update(UserDTO userDTO);
    }
}