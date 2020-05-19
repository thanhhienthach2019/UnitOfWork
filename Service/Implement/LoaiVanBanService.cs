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
    public class LoaiVanBanService:ILoaiVanBanService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        public LoaiVanBanService(IMapper mapper,IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public LoaiVanBanDTO Add(LoaiVanBanDTO loaiVanBanDTO)
        {
            loaivanban loaivanban = _unitOfWork.LoaiVanBanRepository.Add(_mapper.Map<loaivanban>(loaiVanBanDTO));
            _unitOfWork.Commit();
            return _mapper.Map<LoaiVanBanDTO>(loaivanban);
        }
        public LoaiVanBanDTO Delete(object id)
        {
            loaivanban loaivanban = _unitOfWork.LoaiVanBanRepository.Delete(id);
            _unitOfWork.Commit();
            return _mapper.Map<LoaiVanBanDTO>(loaivanban);
        }
        public IEnumerable<LoaiVanBanDTO> GetAll()
        {
            IEnumerable<loaivanban> loaivanban = _unitOfWork.LoaiVanBanRepository.GetAll();
            return _mapper.Map<IEnumerable<LoaiVanBanDTO>>(loaivanban);
        }
        public LoaiVanBanDTO GetById(object id)
        {
            loaivanban loaivanban = _unitOfWork.LoaiVanBanRepository.GetById(id);
            return _mapper.Map<LoaiVanBanDTO>(loaivanban);
        }
        public IEnumerable<LoaiVanBanDTO> GetByPredicate(Expression<Func<LoaiVanBanDTO,bool>> expression)
        {
            Expression<Func<loaivanban, bool>> condition = _mapper.Map < Expression<Func<loaivanban, bool>>>(expression);
            IEnumerable<loaivanban> loaivanbans = _unitOfWork.LoaiVanBanRepository.GetByPredicate(condition);
            return _mapper.Map<IEnumerable<LoaiVanBanDTO>>(loaivanbans);
        }
        public void Update(LoaiVanBanDTO loaiVanBanDTO)
        {
            loaivanban loaivanban = _mapper.Map<loaivanban>(loaiVanBanDTO);
            _unitOfWork.LoaiVanBanRepository.Update(loaivanban);
            _unitOfWork.Commit();
        }
    }
}
