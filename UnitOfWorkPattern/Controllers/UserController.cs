using Microsoft.AspNetCore.Mvc;
using Service.Implement;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitOfWorkPattern.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController()
        {
            _userService=new UserService()
        }
        [HttpGet]
        public ActionResult Get()
        {

        }
    }
}
