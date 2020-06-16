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
    public class LoaiTinService : ILoaiTinService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public LoaiTinService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<LoaiTinDTO> Add(LoaiTinDTO loaiTinDTO)
        {
            loaitin loaitin = _unitOfWork.LoaiTinRepository.Add(_mapper.Map<loaitin>(loaiTinDTO));
            await _unitOfWork.CommitAsync();
            return _mapper.Map<LoaiTinDTO>(loaitin);
        }

        public async Task<LoaiTinDTO> Delete(object id)
        {
            loaitin loaitin = _unitOfWork.LoaiTinRepository.Delete(id);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<LoaiTinDTO>(loaitin);
        }

        public async Task<IEnumerable<LoaiTinDTO>> GetAll()
        {
            IEnumerable<loaitin> loaitins = await _unitOfWork.LoaiTinRepository.GetAll();
            return _mapper.Map<IEnumerable<LoaiTinDTO>>(loaitins);
        }

        public async Task<IEnumerable<LoaiTinDTO>> GetAllPar()
        {
            IEnumerable<loaitin> loaitins = await _unitOfWork.LoaiTinRepository.GetAllPar(d => d.theloai);
            return _mapper.Map<IEnumerable<LoaiTinDTO>>(loaitins);
        }

        public async Task<LoaiTinDTO> GetById(object id)
        {
            loaitin loaitin = await _unitOfWork.LoaiTinRepository.GetById(id);
            return _mapper.Map<LoaiTinDTO>(loaitin);
        }

        public IEnumerable<LoaiTinDTO> GetByPredicate(Expression<Func<LoaiTinDTO, bool>> expression)
        {
            Expression<Func<loaitin, bool>> condition = _mapper.Map<Expression<Func<loaitin, bool>>>(expression);
            IEnumerable<loaitin> loaitins = _unitOfWork.LoaiTinRepository.GetByPredicate(condition);
            return _mapper.Map<IEnumerable<LoaiTinDTO>>(loaitins);
        }

        public async Task<IEnumerable<LoaiTinDTO>> GetMultiByPredicate(Expression<Func<LoaiTinDTO, bool>> expression)
        {
            Expression<Func<loaitin, bool>> codition = _mapper.MapExpression<Expression<Func<loaitin, bool>>>(expression);
            IEnumerable<loaitin> loaitins = await _unitOfWork.LoaiTinRepository.GetMultiByPredicate(codition, x => x.theloai);
            return _mapper.Map<IEnumerable<LoaiTinDTO>>(loaitins);
        }

        public async Task<LoaiTinDTO> GetSingleByPredicate(Expression<Func<LoaiTinDTO, bool>> expression)
        {
            Expression<Func<loaitin, bool>> condition = _mapper.MapExpression<Expression<Func<loaitin, bool>>>(expression);
            loaitin loaitin = await _unitOfWork.LoaiTinRepository.GetSingleByPredicate(condition, x => x.theloai);
            return _mapper.Map<LoaiTinDTO>(loaitin);
        }

        public void Update(LoaiTinDTO loaiTinDTO)
        {
            loaitin loaitin = _mapper.Map<loaitin>(loaiTinDTO);
            _unitOfWork.LoaiTinRepository.Update(loaitin);
            _unitOfWork.CommitAsync();
        }
    }
}