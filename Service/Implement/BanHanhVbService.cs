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
    public class BanHanhVbService : IBanHanhVbService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public BanHanhVbService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<BanhanhvbDTO> Add(BanhanhvbDTO banhanhvbDTO)
        {
            Banhanhvb banhanhvb = _unitOfWork.BanHanhVbRepository.Add(_mapper.Map<Banhanhvb>(banhanhvbDTO));
            await _unitOfWork.CommitAsync();
            return _mapper.Map<BanhanhvbDTO>(banhanhvb);
        }

        public async Task<BanhanhvbDTO> Delete(object id)
        {
            Banhanhvb banhanhvb = _unitOfWork.BanHanhVbRepository.Delete(id);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<BanhanhvbDTO>(banhanhvb);
        }

        public async Task<IEnumerable<BanhanhvbDTO>> GetAll()
        {
            IEnumerable<Banhanhvb> banhanhvbs = await _unitOfWork.BanHanhVbRepository.GetAll();
            return _mapper.Map<IEnumerable<BanhanhvbDTO>>(banhanhvbs);
        }

        public async Task<IEnumerable<BanhanhvbDTO>> GetAllPar()
        {
            IEnumerable<Banhanhvb> banhanhvbs = await _unitOfWork.BanHanhVbRepository.GetAllPar();
            return _mapper.Map<IEnumerable<BanhanhvbDTO>>(banhanhvbs);
        }

        public async Task<BanhanhvbDTO> GetById(object id)
        {
            Banhanhvb banhanhvb = await _unitOfWork.BanHanhVbRepository.GetById(id);
            return _mapper.Map<BanhanhvbDTO>(banhanhvb);
        }

        public async Task<IEnumerable<BanhanhvbDTO>> GetByPredicate(Expression<Func<BanhanhvbDTO, bool>> expression)
        {
            Expression<Func<Banhanhvb, bool>> condition = _mapper.Map<Expression<Func<Banhanhvb, bool>>>(expression);
            IEnumerable<Banhanhvb> banhanhvbs = await _unitOfWork.BanHanhVbRepository.GetByPredicate(condition);
            return _mapper.Map<IEnumerable<BanhanhvbDTO>>(banhanhvbs);
        }

        public async Task<IEnumerable<BanhanhvbDTO>> GetMultiPredicate(Expression<Func<BanhanhvbDTO, bool>> expression)
        {
            Expression<Func<Banhanhvb, bool>> condition = _mapper.MapExpression<Expression<Func<Banhanhvb, bool>>>(expression);
            IEnumerable<Banhanhvb> banhanhvbs = await _unitOfWork.BanHanhVbRepository.GetByMultiPredicate(condition, x => x.vanban);
            return _mapper.Map<IEnumerable<BanhanhvbDTO>>(banhanhvbs);
        }

        public async Task<BanhanhvbDTO> GetSinglePredicate(Expression<Func<BanhanhvbDTO, bool>> expression)
        {
            Expression<Func<Banhanhvb, bool>> condition = _mapper.MapExpression<Expression<Func<Banhanhvb, bool>>>(expression);
            Banhanhvb banhanhvb = await _unitOfWork.BanHanhVbRepository.GetSinglePredicate(condition, x => x.vanban);
            return _mapper.Map<BanhanhvbDTO>(banhanhvb);
        }

        public void Update(BanhanhvbDTO banhanhvbDTO)
        {
            Banhanhvb banhanhvb = _mapper.Map<Banhanhvb>(banhanhvbDTO);
            _unitOfWork.BanHanhVbRepository.Update(banhanhvb);
            _unitOfWork.CommitAsync();
        }
    }
}