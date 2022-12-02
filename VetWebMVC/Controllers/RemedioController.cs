using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VetWeb;
using VetWebMVC.Services;

namespace VetWebMVC.Controllers
{
    public class RemedioController : Controller
    {
        private readonly RemedioServices _remedioServices;

        public RemedioController(RemedioServices remedioServices)
        {
            _remedioServices = remedioServices;
        }


        // GET: RemedioController
        public ActionResult Index()
        {
            var listaRemedios = _remedioServices.ListarRemedios();
            return View(listaRemedios);
        }

        // GET: RemedioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RemedioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RemedioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Remedio remedio)
        {
            try
            {
                _remedioServices.AdicionaRemedio(remedio);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RemedioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RemedioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RemedioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RemedioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
