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
    public class TaiLieuService : ITaiLieuService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;
        public TaiLieuService(IMapper mapper,IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public TaiLieuDTO Add(TaiLieuDTO taiLieuDTO)
        {
            tailieu tailieu = _unitOfWork.TaiLieuRepository.Add(_mapper.Map<tailieu>(taiLieuDTO)) ;
            _unitOfWork.Commit();
            return _mapper.Map<TaiLieuDTO>(tailieu);
        }

        public TaiLieuDTO Delete(object id)
        {
            tailieu tailieu = _unitOfWork.TaiLieuRepository.Delete(id);
            _unitOfWork.Commit();
            return _mapper.Map<TaiLieuDTO>(tailieu);
        }

        public IEnumerable<TaiLieuDTO> GetAll()
        {
            IEnumerable<tailieu> tailieus = _unitOfWork.TaiLieuRepository.GetAll();
            return _mapper.Map<IEnumerable<TaiLieuDTO>>(tailieus);
        }

        public TaiLieuDTO GetById(object id)
        {
            tailieu tailieu = _unitOfWork.TaiLieuRepository.GetById(id);
            return _mapper.Map<TaiLieuDTO>(tailieu);
        }

        public IEnumerable<TaiLieuDTO> GetByPredicate(Expression<Func<TaiLieuDTO, bool>> expression)
        {
            Expression<Func<tailieu, bool>> condition = _mapper.Map<Expression<Func<tailieu, bool>>>(expression);
            IEnumerable<tailieu> tailieus = _unitOfWork.TaiLieuRepository.GetByPredicate(condition);
            return _mapper.Map<IEnumerable<TaiLieuDTO>>(tailieus);
        }

        public void Update(TaiLieuDTO taiLieuDTO)
        {
            tailieu tailieu = _mapper.Map<tailieu>(taiLieuDTO);
            _unitOfWork.TaiLieuRepository.Update(tailieu);
            _unitOfWork.Commit();
        }
    }
}
