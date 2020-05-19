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
    public class VanBanService:IVanBanService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public VanBanService(IMapper mapper,IUnitOfWork unitOfWork)
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
        public IEnumerable<VanBanDTO> GetAll()
        {
            IEnumerable<vanban> vanban = _unitOfWork.VanBanRepository.GetAll();
            return _mapper.Map<IEnumerable<VanBanDTO>>(vanban);
        }
        public VanBanDTO GetById(object id)
        {
            vanban vanban = _unitOfWork.VanBanRepository.GetById(id);
            return _mapper.Map<VanBanDTO>(vanban);
        }
        public IEnumerable<VanBanDTO>GetByPredicate(Expression<Func<VanBanDTO,bool>> expression)
        {
            Expression<Func<vanban, bool>> condition = _mapper.Map<Expression<Func<vanban, bool>>>(expression);
            IEnumerable<vanban> vanbans = _unitOfWork.VanBanRepository.GetByPredicate(condition);
            return _mapper.Map<IEnumerable<VanBanDTO>>(vanbans);
        }
    }
}
