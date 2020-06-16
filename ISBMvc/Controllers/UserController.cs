using DTO;
using Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ISBMvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: User
        public async Task<ActionResult> Index()
        {
            IEnumerable<UserDTO> result = await _userService.GetByPredicate(x => x.donvi == "1103000000" && x.password == "1962026656160185351301320480154111117132155");
            return View(result);
        }
    }
}