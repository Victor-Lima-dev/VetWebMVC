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

        //Método para adicionar um parametroBase
        //public void AdicionaParametroBase(Animal animal)
        //{
        //    var parametroId = 1;
        //    var normal = "Normal";

        //    var parametroBase = new Parametros(parametroId, normal, normal, normal, normal, normal);


        //    animal.Parametros = parametroBase;
        //}


        //Método para listar todos os animais e parametros

        public List<Animal> ListaAnimais()
        {
            return _context.Animais.ToList();
        }
        //public List<Parametros> ListaParametros()
        //{
        //    return _context.Parametros.ToList();
        //}

        //Método para adicionar um animal para a lista
        public void AdicionaAnimal(Animal animal)
        {
            var listaAnimais = _context.Animais.ToList();

            listaAnimais.Add(animal);
            _context.SaveChanges();
        }



    }
}
