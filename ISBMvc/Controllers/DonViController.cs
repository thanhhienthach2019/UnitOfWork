using DTO;
using Service.Interface;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
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
        public async Task<ActionResult> Index()
        {
            IEnumerable<DonViDTO> result = await _donViService.GetAllPar();
            return View(result);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Insert(DonViDTO donViDTO)
        {
            DonViDTO result = await _donViService.Add(donViDTO);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Update(string ms_dv)
        {
            if (ms_dv == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonViDTO donViDTO = await _donViService.GetByID(ms_dv);
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

        public async Task<ActionResult> Delete(string ms_dv)
        {
            if (ms_dv == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonViDTO donViDTO = await _donViService.Delete(ms_dv);
            if (donViDTO == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string ms_dv)
        {
            DonViDTO donViDTO = await _donViService.Delete(ms_dv);
            return RedirectToAction("Index");
        }
    }
}