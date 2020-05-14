using AutoMapper;
using Data;
using DTO;
using Moq;
using Repository.Infrastructure.Interface;
using Repository.Repository.Interface;
using Service.AutoMapper;
using Service.Implement;
using Service.Interface;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Service.Test
{
    public class DonViServiceTest
    {
        private IDonViService _donViService;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private Mock<IDonviRepository> _mockDonviRepository;

        public DonViServiceTest()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockDonviRepository = new Mock<IDonviRepository>();
            _mockUnitOfWork.Setup(u => u.DonViRepository).Returns(_mockDonviRepository.Object);
            var _mapper = new MapperConfiguration(map => map.AddProfile(new MappingProfile()));
            _donViService = new DonViService(_mapper.CreateMapper(), _mockUnitOfWork.Object);
        }

        [Fact]
        public void GetAll_Test()
        {
            IEnumerable<DonVi> donVis = new List<DonVi>() {
                new DonVi() { MS_DV = "1102000000", TenDonVi = "PHÒNG CÔNG NGHỆ THÔNG TIN" },
                new DonVi() { MS_DV = "1103000000", TenDonVi = "PHÒNG HÀNH CHÁNH NHÂN SỰ" }
            };
            _mockUnitOfWork.Setup(u => u.DonViRepository.GetAll()).Returns(donVis);
            IEnumerable<DonViDTO> actual = _donViService.GetAll();

            int expected = 2;
            Assert.Equal(expected, actual.Count());
        }

        [Theory]
        [InlineData("1102000000", "1102000000")]
        public void GetByID_Test(string ms_dv, string expected)
        {
            DonVi donVi = new DonVi() { MS_DV = "1102000000", TenDonVi = "PHÒNG CÔNG NGHỆ THÔNG TIN" };
            _mockUnitOfWork.Setup(u => u.DonViRepository.GetById(It.IsAny<string>())).Returns(donVi);

            DonViDTO actual = _donViService.GetByID(ms_dv);

            Assert.Equal(expected, actual.MS_DV);
        }
    }
}