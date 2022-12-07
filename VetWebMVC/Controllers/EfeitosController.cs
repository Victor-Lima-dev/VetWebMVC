using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using VetWeb;
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

        public IActionResult Teste(int animalId,int remedioId)
        {
            
            var animalSelecionado = _animalServices.DetalheAnimal(animalId);
            var remedioSelecionado = _remedioServices.DetalheRemedio(remedioId);

            var teste = new AnimalRemedioViewModel(animalSelecionado, remedioSelecionado);


            return View(teste);
        }
       
        public IActionResult Index()
        {
            
          
            var listaAnimais = _animalServices.ListaAnimais();
            var listaRemedios = _remedioServices.ListarRemedios();

            ViewBag.animais = listaAnimais;
            ViewBag.remedios = listaRemedios;

            var listaCompleta = new ListaAnimaisRemediosViewModel(listaAnimais, listaRemedios);

            return View(listaCompleta);
        }


        //ta chegando 0 aqui, por isso ta passando, ta chegando um objeto todo nulo
        //o método funciona, o que ta faltando é enviar o objeto preenchido pra ele
        

        [HttpPost]
        public IActionResult AplicaEfeito(Animal animal, Remedio remedio)
        {
           var animalTeste = _context.Animais.FirstOrDefault(c => c.AnimalId == animal.AnimalId);
           var remedioTeste = _context.Remedios.FirstOrDefault(c => c.RemedioId == remedio.RemedioId);

            _remedioServices.ConfereTodosOsMetodos(animalTeste, remedioTeste);

            //return para a view de teste enviando um id do objeto
            return RedirectToAction("Teste", new { animalId = animal.AnimalId, remedioId = remedio.RemedioId });




        }



    }
}
