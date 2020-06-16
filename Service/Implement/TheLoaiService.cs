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
    public class TheLoaiService : ITheLoaiService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public TheLoaiService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<TheLoaiDTO> Add(TheLoaiDTO theLoaiDTO)
        {
            theloai theloai = _unitOfWork.TheLoaiRepository.Add(_mapper.Map<theloai>(theLoaiDTO));
            await _unitOfWork.CommitAsync();
            return _mapper.Map<TheLoaiDTO>(theloai);
        }

        public async Task<TheLoaiDTO> Delete(object id)
        {
            theloai theloai = _unitOfWork.TheLoaiRepository.Delete(id);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<TheLoaiDTO>(theloai);
        }

        public async Task<IEnumerable<TheLoaiDTO>> GetAll()
        {
            IEnumerable<theloai> theloais = await _unitOfWork.TheLoaiRepository.GetAll();
            return _mapper.Map<IEnumerable<TheLoaiDTO>>(theloais);
        }

        public async Task<TheLoaiDTO> GetById(object id)
        {
            theloai theLoai = await _unitOfWork.TheLoaiRepository.GetById(id);
            return _mapper.Map<TheLoaiDTO>(theLoai);
        }

        public IEnumerable<TheLoaiDTO> GetByPredicate(Expression<Func<TheLoaiDTO, bool>> expression)
        {
            Expression<Func<theloai, bool>> condition = _mapper.Map<Expression<Func<theloai, bool>>>(expression);
            IEnumerable<theloai> theloais = _unitOfWork.TheLoaiRepository.GetByPredicate(condition);
            return _mapper.Map<IEnumerable<TheLoaiDTO>>(theloais);
        }

        public void Update(TheLoaiDTO theLoaiDTO)
        {
            theloai theloai = _mapper.Map<theloai>(theLoaiDTO);
            _unitOfWork.TheLoaiRepository.Update(theloai);
            _unitOfWork.CommitAsync();
        }
    }
}