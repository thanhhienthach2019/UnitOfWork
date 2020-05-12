using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetAll();
        UserDTO GetByID(object id);
        UserDTO GetByPredicate(Expression<Func<UserDTO, bool>> predicate);
        UserDTO Add(UserDTO userDTO);
        UserDTO Delete(object id);
        void Update(UserDTO userDTO);
    }
}
