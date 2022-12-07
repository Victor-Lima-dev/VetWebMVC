using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VetWeb;
using VetWebMVC.Context;
using VetWebMVC.Services;

namespace VetWebMVC.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalServices _animalServices;

        public AnimalController(AnimalServices animalServices, AppDbContext context)
        {
            _animalServices = animalServices;
        }

        public ActionResult Index()
        {
            var lista = _animalServices.ListaAnimais();
            

            return View(lista);
        }

        // GET: AnimalController/Details/5
        
        public ActionResult Details(int id)
        {
            var destaque = _animalServices.DetalheAnimal(id);

            return View(destaque);

        }

        // GET: AnimalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Animal animal)
        {
                           
                _animalServices.AdicionaAnimal(animal);
                return RedirectToAction(nameof(Index));
            
            
        }

        // GET: AnimalController/Edit/5
        public ActionResult Edit(int id)
        {
            

            return View(_animalServices.DetalheAnimal(id));
        }

        // POST: AnimalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                _animalServices.EditarAnimal(id);
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
            
            return View(_animalServices.DetalheAnimal(id));
        }

        // POST: AnimalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _animalServices.ExcluirAnimal(id);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
