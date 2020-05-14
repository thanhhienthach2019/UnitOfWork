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
    public class UserServiceTest
    {
        private IUserService _userService;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private Mock<IUserRepository> _mockRepository;

        public UserServiceTest()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockRepository = new Mock<IUserRepository>();
            _mockUnitOfWork.Setup(u => u.UserRepository).Returns(_mockRepository.Object);
            var _mapper = new MapperConfiguration(map => map.AddProfile(new MappingProfile()));
            _userService = new UserService(_mapper.CreateMapper(), _mockUnitOfWork.Object);
        }

        [Fact]
        public void GetAll_Test()
        {
            IEnumerable<user> users = new List<user>() {
                new user() { id = "Id Hiền nè", name = "Hiền nè" },
                new user() { id = "Id Trung nè", name = "Trung nè" }
            };
            _mockUnitOfWork.Setup(u => u.UserRepository.GetAll()).Returns(users);
            IEnumerable<UserDTO> actual = _userService.GetAll();

            int expected = 2;
            Assert.Equal(expected, actual.Count());
        }
        [Theory]
        [InlineData("1 hien","1 hien")]
        public void GetByID_Test(string ids, string expected)
        {
            user users = new user() { id = ids, name = "Hiền nè" };
            _mockUnitOfWork.Setup(u => u.UserRepository.GetById(It.IsAny<string>())).Returns(users);

            UserDTO actual = _userService.GetByID(ids);

            Assert.Equal(expected, actual.id);
        }
    }
}