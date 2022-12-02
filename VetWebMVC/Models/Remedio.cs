using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetWeb
{
    public class Remedio
    {
        public string Nome { get; set; }
        public int RemedioId { get; set; }
        public string PrincipioAtivo { get; set; }
        public string MecanismoAcao { get; set; }
        public string ViaAdministracao { get; set; }
        public string EfeitoAdverso { get; set; }

        //Efeitos Sistemicos
        public Boolean PodeAumentarFrequenciaCardiaca { get; set; }
        public Boolean PodeDiminuirFrequenciaCardiaca { get; set; }

        public Boolean PodeAumentarFrequenciaRespiratoria { get; set; }
        public Boolean PodeDiminuirFrequenciaRespiratoria { get; set; }

        public Boolean PodeAumentarPressaoArterial { get; set; }
        public Boolean PodeDiminuirPressaoArterial { get; set; }

        public Boolean PodeAumentarHematocritos { get; set; }
        public Boolean PodeDiminuirHematocritos { get; set; }

        public Boolean PodeAumentarLeucocitos { get; set; }
        public Boolean PodeDiminuirLeucocitos { get; set; }



        public void ConfereTodosOsMetodos(Animal parametros, Remedio efeitoSistemico)
        {
            ConfereFrequenciaCardiaca(parametros, efeitoSistemico);
            ConfereFrequenciaRespiratoria(parametros, efeitoSistemico);
            ConferePressaoArterial(parametros, efeitoSistemico);
            ConfereHematocritos(parametros, efeitoSistemico);
            ConfereLeucocitos(parametros, efeitoSistemico);
        }

        public void ConfereFrequenciaCardiaca(Animal parametros, Remedio efeitoSistemico)
        {
            if (efeitoSistemico.PodeAumentarFrequenciaCardiaca == true)
            {
                parametros.FrequenciaCardiaca = "AUMENTOU";
            }

            else if (efeitoSistemico.PodeDiminuirFrequenciaCardiaca == true)
            {
                parametros.FrequenciaCardiaca = "DIMINUIU";
            }

            else { return; }
        }
        public void ConfereFrequenciaRespiratoria(Animal parametros, Remedio efeitoSistemico)
        {
            if (efeitoSistemico.PodeAumentarFrequenciaRespiratoria == true)
            {
                parametros.FrequenciaRespiratoria = "AUMENTOU";
            }
            else if (efeitoSistemico.PodeDiminuirFrequenciaRespiratoria == true)
            {
                parametros.FrequenciaRespiratoria = "DIMINUIU";
            }

            else { return; }
        }

        public void ConferePressaoArterial(Animal parametros, Remedio efeitoSistemico)
        {
            if (efeitoSistemico.PodeAumentarPressaoArterial == true)
            {
                parametros.PressaoArterialSistemica = "AUMENTOU";
            }
            else if (efeitoSistemico.PodeDiminuirPressaoArterial == true)
            {
                parametros.PressaoArterialSistemica = "DIMINUIU";
            }
            else { return; }
        }

        public void ConfereHematocritos(Animal parametros, Remedio efeitoSistemico)
        {
            if (efeitoSistemico.PodeAumentarHematocritos == true)
            {
                parametros.Hematocrito = "AUMENTOU";
            }

            else if (efeitoSistemico.PodeDiminuirHematocritos == true)
            {
                parametros.Hematocrito = "DIMINUIU";
            }
            else { return; }
        }

        public void ConfereLeucocitos(Animal parametros, Remedio efeitoSistemico)
        {
            if (efeitoSistemico.PodeAumentarLeucocitos == true)
            {
                parametros.Leucocitos = "AUMENTOU";
            }

            else if (efeitoSistemico.PodeDiminuirLeucocitos == true)
            {
                parametros.Leucocitos = "DIMINUIU";
            }
            else { return; }
        }


    }

    
}
