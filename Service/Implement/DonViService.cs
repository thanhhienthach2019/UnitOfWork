using AutoMapper;
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
    public class DonViService : IDonViService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public DonViService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<DonViDTO> Add(DonViDTO donViDTO)
        {
            DonVi donVi = _unitOfWork.DonViRepository.Add(_mapper.Map<DonVi>(donViDTO));
            await _unitOfWork.CommitAsync();
            return _mapper.Map<DonViDTO>(donVi);
        }

        public async Task<DonViDTO> Delete(object id)
        {
            DonVi donVi = _unitOfWork.DonViRepository.Delete(id);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<DonViDTO>(donVi);
        }

        public async Task<IEnumerable<DonViDTO>> GetAll()
        {
            IEnumerable<DonVi> donVis = await _unitOfWork.DonViRepository.GetAll();
            return _mapper.Map<IEnumerable<DonViDTO>>(donVis);
        }

        public async Task<IEnumerable<DonViDTO>> GetAllPar()
        {
            IEnumerable<DonVi> donvis = await _unitOfWork.DonViRepository.GetAllPar();
            return _mapper.Map<IEnumerable<DonViDTO>>(donvis);
        }

        public async Task<DonViDTO> GetByID(object id)
        {
            DonVi donVi = await _unitOfWork.DonViRepository.GetById(id);
            return _mapper.Map<DonViDTO>(donVi);
        }

        public IEnumerable<DonViDTO> GetByPredicate(Expression<Func<DonViDTO, bool>> predicate)
        {
            Expression<Func<DonVi, bool>> condition = _mapper.Map<Expression<Func<DonVi, bool>>>(predicate);
            IEnumerable<DonVi> donVis = _unitOfWork.DonViRepository.GetByPredicate(condition);
            return _mapper.Map<IEnumerable<DonViDTO>>(donVis);
        }

        public void Update(DonViDTO donViDTO)
        {
            DonVi donVi = _mapper.Map<DonVi>(donViDTO);
            _unitOfWork.DonViRepository.Update(donVi);
            _unitOfWork.CommitAsync();
        }
    }
}