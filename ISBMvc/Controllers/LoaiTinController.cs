using DTO;
using Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ISBMvc.Controllers
{
    public class LoaiTinController : Controller
    {
        private ILoaiTinService _loaiTinService;

        public LoaiTinController(ILoaiTinService loaiTinService)
        {
            _loaiTinService = loaiTinService;
        }

        // GET: LoaiTin
        public async Task<ActionResult> Index()
        {
            //IEnumerable<LoaiTinDTO> result = await _loaiTinService.GetAllPar();
            IEnumerable<LoaiTinDTO> result = await _loaiTinService.GetMultiByPredicate(x => x.status == 2);
            //LoaiTinDTO result = await _loaiTinService.GetSingleByPredicate(x => x.status == 2);
            return View(result);
        }
    }
}