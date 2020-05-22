using DTO;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISBMvc.Controllers
{
    public class LoaiTaiLieuController : Controller
    {
        private ILoaiTaiLieuService _loaiTaiLieuService;
        public LoaiTaiLieuController(ILoaiTaiLieuService loaiTaiLieuService)
        {
            _loaiTaiLieuService = loaiTaiLieuService;
        }
        // GET: LoaiTaiLieu
        public ActionResult Index()
        {
            //IEnumerable<LoaiTaiLieuDTO> result = _loaiTaiLieuService.GetAll();
            IEnumerable<GetLoaiTaiLieuDTO> result = _loaiTaiLieuService.GetLoaiTaiLieu();
            return View(result);
        }
    }
}