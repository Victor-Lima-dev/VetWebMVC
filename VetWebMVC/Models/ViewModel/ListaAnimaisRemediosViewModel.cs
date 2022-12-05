using VetWeb;

namespace VetWebMVC.Models.ViewModel
{
    public class ListaAnimaisRemediosViewModel
    {
        public ICollection<Animal> ListaAnimais { get; set; }
        public ICollection<Remedio> ListaRemedios { get; set; }

        public Animal Animal { get; set; }
        public Remedio Remedio { get; set; }

        public ListaAnimaisRemediosViewModel(ICollection<Animal> listaAnimais, ICollection<Remedio> listaRemedios)
        {
            ListaAnimais = listaAnimais;
            ListaRemedios = listaRemedios;
        }

        public ListaAnimaisRemediosViewModel(Animal animal, Remedio remedio)
        {
            Animal = animal;
            Remedio = remedio;
        }

        public ListaAnimaisRemediosViewModel()
        {
        }
    }
}
