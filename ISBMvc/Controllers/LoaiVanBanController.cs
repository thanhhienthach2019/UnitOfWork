using DTO;
using Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ISBMvc.Controllers
{
    public class LoaiVanBanController : Controller
    {
        private ILoaiVanBanService _loaiVanBanService;

        public LoaiVanBanController(ILoaiVanBanService loaiVanBanService)
        {
            _loaiVanBanService = loaiVanBanService;
        }

        // GET: LoaiVanBan
        public async Task<ActionResult> Index()
        {
            IEnumerable<LoaiVanBanDTO> result = await _loaiVanBanService.GetAll();
            return View(result);
        }
    }
}