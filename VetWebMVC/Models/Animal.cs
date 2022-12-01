using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetWeb
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Nome { get; set; }
        public string FaseDaVida { get; set; }

        public string Sexo { get; set; }
        public string Comorbidade { get; set; }
        public string Condicao { get; set; }
        public Parametros Parametros { get; set; }
        public int ParametrosId { get; set; }

        public void SetaParametros(Animal animal,int id, IEnumerable<Parametros> parametros)
        {
            animal.Parametros = parametros.FirstOrDefault(c => c.ParametrosId == id);
        }


    }
}
