using DTO;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISBMvc.Controllers
{
    public class DonViController : Controller
    {
        private readonly IDonViService _donViService;
        public DonViController(IDonViService donViService)
        {
            _donViService = donViService;
        }
        // GET: DonVi
        public ActionResult Index()
        {
            IEnumerable<DonViDTO> result = _donViService.GetAll();
            return View(result);
        }
    }
}