using Microsoft.AspNetCore.Mvc;
using VetWebMVC.Context;
using VetWebMVC.Models.ViewModel;
using VetWebMVC.Services;

namespace VetWebMVC.Controllers
{
    public class EfeitosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly AnimalServices _animalServices;
        private readonly RemedioServices _remedioServices;

        public EfeitosController(AppDbContext context, AnimalServices animalServices, RemedioServices remedioServices)
        {
            _context = context;
            _animalServices = animalServices;
            _remedioServices = remedioServices;
        }

        public IActionResult Index()
        {
            var listaAnimais = _animalServices.ListaAnimais();
            var listaRemedios = _remedioServices.ListarRemedios();

            var listaCompleta = new ListaAnimaisRemediosViewModel(listaAnimais, listaRemedios);

            return View(listaCompleta);
        }

     

    }
}
