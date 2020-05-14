using DTO;
using Service.Interface;
using System.Collections.Generic;
using System.Net;
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

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(DonViDTO donViDTO)
        {
            DonViDTO result = _donViService.Add(donViDTO);
            return RedirectToAction("Index");
        }

        public ActionResult Update(string ms_dv)
        {
            if (ms_dv == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonViDTO donViDTO = _donViService.GetByID(ms_dv);
            if (donViDTO == null)
            {
                return HttpNotFound();
            }
            return View(donViDTO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(DonViDTO donViDTO)
        {
            _donViService.Update(donViDTO);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string ms_dv)
        {
            if (ms_dv == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonViDTO donViDTO = _donViService.Delete(ms_dv);
            if (donViDTO == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string ms_dv)
        {
            DonViDTO donViDTO = _donViService.Delete(ms_dv);
            return RedirectToAction("Index");
        }
    }
}