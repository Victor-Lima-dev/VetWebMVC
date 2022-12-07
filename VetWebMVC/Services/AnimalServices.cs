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
    

        //Método para adicionar um animal para a lista
        public void AdicionaAnimal(Animal animal)
        {
            _context.Animais.Add(animal);
            _context.SaveChanges();
        }

        //Método para a view de detalhes
        
        public Animal DetalheAnimal(int id)
        {
            return _context.Animais.FirstOrDefault(c => c.AnimalId == id);
        }

        //Método para excluir um animal
        
        public void ExcluirAnimal(int id)
        {
            var animalExcluido = _context.Animais.FirstOrDefault(c => c.AnimalId == id);
            _context.Animais.Remove(animalExcluido);
            _context.SaveChanges();
        }

        //Método para editar um animal
        public void EditarAnimal(int id)
        {
            var animalEditado = _context.Animais.FirstOrDefault(c => c.AnimalId == id);
            _context.Update(animalEditado);
            _context.SaveChanges();

        }

    }
}
