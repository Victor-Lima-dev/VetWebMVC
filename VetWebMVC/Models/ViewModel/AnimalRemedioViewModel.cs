using VetWeb;

namespace VetWebMVC.Models.ViewModel
{
    public class AnimalRemedioViewModel
    {
        public Animal Animal { get; set; }
        public Remedio Remedio { get; set; }

        public AnimalRemedioViewModel(Animal animal, Remedio remedio)
        {
            Animal = animal;
            Remedio = remedio;
        }
    }
}
