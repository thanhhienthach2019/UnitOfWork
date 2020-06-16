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
    public class TaiLieuService : ITaiLieuService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public TaiLieuService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public TaiLieuDTO Add(TaiLieuDTO taiLieuDTO)
        {
            tailieu tailieu = _unitOfWork.TaiLieuRepository.Add(_mapper.Map<tailieu>(taiLieuDTO));
            _unitOfWork.Commit();
            return _mapper.Map<TaiLieuDTO>(tailieu);
        }

        public async Task<TaiLieuDTO> Delete(object id)
        {
            tailieu tailieu = _unitOfWork.TaiLieuRepository.Delete(id);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<TaiLieuDTO>(tailieu);
        }

        public async Task<IEnumerable<TaiLieuDTO>> GetAll()
        {
            IEnumerable<tailieu> tailieus = await _unitOfWork.TaiLieuRepository.GetAll();
            return _mapper.Map<IEnumerable<TaiLieuDTO>>(tailieus);
        }

        public async Task<IEnumerable<TaiLieuDTO>> GetAllPar()
        {
            IEnumerable<tailieu> tailieus = await _unitOfWork.TaiLieuRepository.GetAllPar();
            return _mapper.Map<IEnumerable<TaiLieuDTO>>(tailieus);
        }

        public async Task<TaiLieuDTO> GetById(object id)
        {
            tailieu tailieu = await _unitOfWork.TaiLieuRepository.GetById(id);
            return _mapper.Map<TaiLieuDTO>(tailieu);
        }

        public async Task<IEnumerable<TaiLieuDTO>> GetByPredicate(Expression<Func<TaiLieuDTO, bool>> expression)
        {
            Expression<Func<tailieu, bool>> condition = _mapper.Map<Expression<Func<tailieu, bool>>>(expression);
            IEnumerable<tailieu> tailieus = await _unitOfWork.TaiLieuRepository.GetByPredicate(condition);
            return _mapper.Map<IEnumerable<TaiLieuDTO>>(tailieus);
        }

        public async Task<IEnumerable<TaiLieuDTO>> GetMultiByPredicate(Expression<Func<TaiLieuDTO, bool>> expression)
        {
            Expression<Func<tailieu, bool>> condition = _mapper.MapExpression<Expression<Func<tailieu, bool>>>(expression);
            IEnumerable<tailieu> tailieus = await _unitOfWork.TaiLieuRepository.GetMultiByPredicate(condition, x => x.user);
            return _mapper.Map<IEnumerable<TaiLieuDTO>>(tailieus);
        }

        public async Task<TaiLieuDTO> GetSingleByPredicate(Expression<Func<TaiLieuDTO, bool>> expression)
        {
            Expression<Func<tailieu, bool>> condition = _mapper.MapExpression<Expression<Func<tailieu, bool>>>(expression);
            tailieu tailieu = await _unitOfWork.TaiLieuRepository.GetSingleByPredicate(condition, x => x.user);
            return _mapper.Map<TaiLieuDTO>(tailieu);
        }

        public void Update(TaiLieuDTO taiLieuDTO)
        {
            tailieu tailieu = _mapper.Map<tailieu>(taiLieuDTO);
            _unitOfWork.TaiLieuRepository.Update(tailieu);
            _unitOfWork.Commit();
        }

    }
}