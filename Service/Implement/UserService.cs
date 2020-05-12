using AutoMapper;
using Data;
using DTO;
using Repository.Infrastructure.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implement
{
    public class UserService : IUserService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        public UserService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public UserDTO Add(UserDTO userDTO)
        {
            user user = _unitOfWork.UserRepository.Add(_mapper.Map<user>(userDTO));
            _unitOfWork.Commit();
            return _mapper.Map<UserDTO>(user);
        }

        public UserDTO Delete(object id)
        {
            user user = _unitOfWork.UserRepository.Delete(id);
            _unitOfWork.Commit();
            return _mapper.Map<UserDTO>(user);
        }

        public IEnumerable<UserDTO> GetAll()
        {
            IEnumerable<user> users = _unitOfWork.UserRepository.GetAll();
            return _mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public UserDTO GetByID(object id)
        {
            user user = _unitOfWork.UserRepository.GetById(id);
            return _mapper.Map<UserDTO>(user);
        }

        public UserDTO GetByPredicate(Expression<Func<UserDTO, bool>> predicate)
        {
            Expression<Func<user, bool>> p = _mapper.Map<Expression<Func<user, bool>>>(predicate);
            user user = _unitOfWork.UserRepository.GetByPredicate(p);
            return _mapper.Map<UserDTO>(user);
        }

        public void Update(UserDTO userDTO)
        {
            user user = _mapper.Map<user>(userDTO);
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.Commit();
        }
    }
}
