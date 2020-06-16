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
    public class VanBanService : IVanBanService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public VanBanService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public VanBanDTO Add(VanBanDTO vanBanDTO)
        {
            vanban vanban = _unitOfWork.VanBanRepository.Add(_mapper.Map<vanban>(vanBanDTO));
            _unitOfWork.Commit();
            return _mapper.Map<VanBanDTO>(vanban);
        }

        public void Update(VanBanDTO vanBanDTO)
        {
            vanban vanban = _mapper.Map<vanban>(vanBanDTO);
            _unitOfWork.VanBanRepository.Update(vanban);
            _unitOfWork.Commit();
        }

        public VanBanDTO Delete(object id)
        {
            vanban vanban = _unitOfWork.VanBanRepository.Delete(id);
            _unitOfWork.Commit();
            return _mapper.Map<VanBanDTO>(vanban);
        }

        public async Task<IEnumerable<VanBanDTO>> GetAll()
        {
            IEnumerable<vanban> vanban = await _unitOfWork.VanBanRepository.GetAll();
            return _mapper.Map<IEnumerable<VanBanDTO>>(vanban);
        }

        public async Task<VanBanDTO> GetById(object id)
        {
            vanban vanban = await _unitOfWork.VanBanRepository.GetById(id);
            return _mapper.Map<VanBanDTO>(vanban);
        }

        public async Task<IEnumerable<VanBanDTO>> GetByPredicate(Expression<Func<VanBanDTO, bool>> expression)
        {
            Expression<Func<vanban, bool>> condition = _mapper.Map<Expression<Func<vanban, bool>>>(expression);
            IEnumerable<vanban> vanbans = await _unitOfWork.VanBanRepository.GetByPredicate(condition);
            return _mapper.Map<IEnumerable<VanBanDTO>>(vanbans);
        }

        public async Task<IEnumerable<VanBanDTO>> GetAllPar()
        {
            IEnumerable<vanban> vanbans = await _unitOfWork.VanBanRepository.GetAllPar(x => x.loaivanban);
            return _mapper.Map<IEnumerable<VanBanDTO>>(vanbans);
        }

        public async Task<IEnumerable<VanBanDTO>> GetMultiByPredicate(Expression<Func<VanBanDTO, bool>> expression)
        {
            Expression<Func<vanban, bool>> condition = _mapper.MapExpression<Expression<Func<vanban, bool>>>(expression);
            IEnumerable<vanban> vanbans = await _unitOfWork.VanBanRepository.GetMultiByPredicate(condition, x => x.loaivanban);
            return _mapper.Map<IEnumerable<VanBanDTO>>(vanbans);
        }

        public async Task<VanBanDTO> GetSingleByPredicate(Expression<Func<VanBanDTO, bool>> expression)
        {
            Expression<Func<vanban, bool>> condition = _mapper.MapExpression<Expression<Func<vanban, bool>>>(expression);
            vanban vanban = await _unitOfWork.VanBanRepository.GetSingleByPredicate(condition, x => x.loaivanban);
            return _mapper.Map<VanBanDTO>(vanban);
        }
    }
}