using VetWeb;
using VetWebMVC.Context;

namespace VetWebMVC.Services
{
    public class RemedioServices
    {
        private readonly AppDbContext _context;

        public RemedioServices(AppDbContext context)
        {
            _context = context;
        }

        //Método para listar todos os remedios
        public List<Remedio> ListarRemedios()
        {
            return _context.Remedios.ToList();
        }
        
        //Método para adicionar um remedio a lista

        public void AdicionaRemedio(Remedio remedio)
        {
            _context.Remedios.Add(remedio);
            _context.SaveChanges();
        }



    }
}
