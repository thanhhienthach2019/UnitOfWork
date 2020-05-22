using DTO;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public ActionResult Index()
        {
            IEnumerable<VanBanDTO> result = _vanBanService.GetAll();
            return View(result);
        }
    }
}