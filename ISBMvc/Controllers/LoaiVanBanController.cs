using DTO;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public ActionResult Index()
        {
            IEnumerable<LoaiVanBanDTO> result = _loaiVanBanService.GetAll();
            return View(result);
        }
    }
}