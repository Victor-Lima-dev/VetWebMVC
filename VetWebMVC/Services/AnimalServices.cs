using VetWeb;
using VetWebMVC.Context;

namespace VetWebMVC.Services
{
    public class AnimalServices
    {   
        private readonly AppDbContext _context;

        public AnimalServices(AppDbContext context)
        {
            _context = context;
        }

 

        //Método para listar todos os animais e parametros

        public List<Animal> ListaAnimais()
        {
            return _context.Animais.ToList();
        }
        public List<Parametros> ListaParametros()
        {
            return _context.Parametros.ToList();
        }

        //Método para adicionar um animal para a lista
        public void AdicionaAnimal(Animal animal)
        {
            var listaAnimais = _context.Animais.ToList();
            listaAnimais.Add(animal);
            _context.SaveChanges();
        }



    }
}
