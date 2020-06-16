using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using Data;
using DTO;
using Repository.Infrastructure.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public async Task<UserDTO> Add(UserDTO userDTO)
        {
            user user = _unitOfWork.UserRepository.Add(_mapper.Map<user>(userDTO));
            await _unitOfWork.CommitAsync();
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> Delete(object id)
        {
            user user = _unitOfWork.UserRepository.Delete(id);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            IEnumerable<user> users = await _unitOfWork.UserRepository.GetAll();
            return _mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public Task<IEnumerable<UserDTO>> GetAllPar()
        {
            throw new NotImplementedException();
        }

        public async Task<UserDTO> GetByID(object id)
        {
            user user = await _unitOfWork.UserRepository.GetById(id);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<IEnumerable<UserDTO>> GetByPredicate(Expression<Func<UserDTO, bool>> predicate)
        {
            Expression<Func<user, bool>> p = _mapper.Map<Expression<Func<user, bool>>>(predicate);
            IEnumerable<user> user = await _unitOfWork.UserRepository.GetByPredicate(p);
            return _mapper.Map<IEnumerable<UserDTO>>(user);
        }

        public async Task<IEnumerable<UserDTO>> GetMultiByPredicate(Expression<Func<UserDTO, bool>> expression)
        {
            Expression<Func<user, bool>> condition = _mapper.MapExpression<Expression<Func<user, bool>>>(expression);
            IEnumerable<user> users = await _unitOfWork.UserRepository.GetByMultiByPredicate(condition, x => x.donvi);
            return _mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public async Task<UserDTO> GetSingleByPredicate(Expression<Func<UserDTO, bool>> expression)
        {
            Expression<Func<user, bool>> condition = _mapper.MapExpression<Expression<Func<user, bool>>>(expression);
            user user = await _unitOfWork.UserRepository.GetSingleByPredicate(condition, x => x.donvi);
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