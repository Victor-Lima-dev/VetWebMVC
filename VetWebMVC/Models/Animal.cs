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

        //Parametros
        public string FrequenciaCardiaca { get; set; }
        public string FrequenciaRespiratoria { get; set; }
        public string PressaoArterialSistemica { get; set; }
        public string Hematocrito { get; set; }

        public string Leucocitos { get; set; }

        
        
    }
}
