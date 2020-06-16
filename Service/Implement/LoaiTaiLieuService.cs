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
    public class LoaiTaiLieuService : ILoaiTaiLieuService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public LoaiTaiLieuService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public LoaiTaiLieuDTO Add(LoaiTaiLieuDTO loaiTaiLieuDTO)
        {
            loaitailieu loaitailieu = _unitOfWork.LoaiTaiLieuRepository.Add(_mapper.Map<loaitailieu>(loaiTaiLieuDTO));
            _unitOfWork.Commit();
            return _mapper.Map<LoaiTaiLieuDTO>(loaitailieu);
        }

        public LoaiTaiLieuDTO Delete(object id)
        {
            loaitailieu loaitailieu = _unitOfWork.LoaiTaiLieuRepository.Delete(id);
            _unitOfWork.Commit();
            return _mapper.Map<LoaiTaiLieuDTO>(loaitailieu);
        }

        public async Task<IEnumerable<LoaiTaiLieuDTO>> GetAll()
        {
            IEnumerable<loaitailieu> loaitailieus = await _unitOfWork.LoaiTaiLieuRepository.GetAll();
            //IEnumerable<loaitailieu> loaitailieus = _unitOfWork.LoaiTaiLieuRepository.GetAll();

            //var list = loaitailieus.Select((entry, index) => new
            //{
            //    STT = index + 1,
            //    MaLoai = entry.MaLoai,
            //    TenLoai = entry.TenLoai,
            //    Create_at = entry.Create_at,
            //    User_create = entry.User_create
            //}).AsEnumerable();
            return _mapper.Map<IEnumerable<LoaiTaiLieuDTO>>(loaitailieus);
        }

        public async Task<LoaiTaiLieuDTO> GetById(object id)
        {
            loaitailieu loaitailieu = await _unitOfWork.LoaiTaiLieuRepository.GetById(id);
            return _mapper.Map<LoaiTaiLieuDTO>(loaitailieu);
        }

        public IEnumerable<LoaiTaiLieuDTO> GetByPredicate(Expression<Func<LoaiTaiLieuDTO, bool>> expression)
        {
            Expression<Func<loaitailieu, bool>> condition = _mapper.Map<Expression<Func<loaitailieu, bool>>>(expression);
            IEnumerable<loaitailieu> loaitailieus = _unitOfWork.LoaiTaiLieuRepository.GetByPredicate(condition);
            return _mapper.Map<IEnumerable<LoaiTaiLieuDTO>>(loaitailieus);
        }

        public IEnumerable<GetLoaiTaiLieuDTO> GetLoaiTaiLieu()
        {
            IEnumerable<Get_LoaiTaiLieu_Result> get_LoaiTaiLieu_Results = _unitOfWork.LoaiTaiLieuRepository.GetLoaiTaiLieu();
            return _mapper.Map<IEnumerable<GetLoaiTaiLieuDTO>>(get_LoaiTaiLieu_Results);
        }

        public void Update(LoaiTaiLieuDTO loaiTaiLieuDTO)
        {
            loaitailieu loaitailieu = _mapper.Map<loaitailieu>(loaiTaiLieuDTO);
            _unitOfWork.LoaiTaiLieuRepository.Update(loaitailieu);
            _unitOfWork.Commit();
        }
    }
}