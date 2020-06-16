using DTO;
using Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ISBMvc.Controllers
{
    public class VanBanController : Controller
    {
        private IVanBanService _vanBanService;

        public VanBanController(IVanBanService vanBanService)
        {
            _vanBanService = vanBanService;
        }

        // GET: VanBan
        public async Task<ActionResult> Index()
        {
            IEnumerable<VanBanDTO> result = await _vanBanService.GetAll();
            return View(result);
        }
    }
}