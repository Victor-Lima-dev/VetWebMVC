using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VetWebMVC.Context;


namespace VetWebMVC.Controllers
{
    public class AnimalController : Controller
    {
        public readonly AppDbContext _context;

        public AnimalController(AppDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {

            var animais = _context.Animais.ToList();
            var parametros = _context.Parametros.ToList();

            foreach (var item in animais)
            {
                item.EncontraParametros(item, 1, parametros);
            }

   


            return View(animais);
        }

        // GET: AnimalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnimalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: AnimalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnimalController/Edit/5
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

        // GET: AnimalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnimalController/Delete/5
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
