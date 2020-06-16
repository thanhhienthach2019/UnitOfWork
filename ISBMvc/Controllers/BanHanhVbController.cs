using DTO;
using Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ISBMvc.Controllers
{
    public class BanHanhVbController : Controller
    {
        private IBanHanhVbService _banHanhVbService;

        public BanHanhVbController(IBanHanhVbService banHanhVbService)
        {
            _banHanhVbService = banHanhVbService;
        }

        // GET: BanHanhVb
        public async Task<ActionResult> Index()
        {
            IEnumerable<BanhanhvbDTO> result = await _banHanhVbService.GetAll();
            return View(result);
        }
    }
}