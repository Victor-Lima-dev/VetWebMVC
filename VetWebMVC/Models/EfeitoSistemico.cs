

namespace VetWeb
{
    public class EfeitoSistemico
    {
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

        public EfeitoSistemico()
        {
        }

        public EfeitoSistemico(bool podeAumentarFrequenciaCardiaca, bool podeDiminuirFrequenciaCardiaca, bool podeAumentarFrequenciaRespiratoria, bool podeDiminuirFrequenciaRespiratoria, bool podeAumentarPressaoArterial, bool podeDiminuirPressaoArterial, bool podeAumentarHematocritos, bool podeDiminuirHematocritos, bool podeAumentarLeucocitos, bool podeDiminuirLeucocitos)
        {
            PodeAumentarFrequenciaCardiaca = podeAumentarFrequenciaCardiaca;
            PodeDiminuirFrequenciaCardiaca = podeDiminuirFrequenciaCardiaca;
            PodeAumentarFrequenciaRespiratoria = podeAumentarFrequenciaRespiratoria;
            PodeDiminuirFrequenciaRespiratoria = podeDiminuirFrequenciaRespiratoria;
            PodeAumentarPressaoArterial = podeAumentarPressaoArterial;
            PodeDiminuirPressaoArterial = podeDiminuirPressaoArterial;
            PodeAumentarHematocritos = podeAumentarHematocritos;
            PodeDiminuirHematocritos = podeDiminuirHematocritos;
            PodeAumentarLeucocitos = podeAumentarLeucocitos;
            PodeDiminuirLeucocitos = podeDiminuirLeucocitos;
        }

        public void ConfereTodosOsMetodos(Parametros parametros, EfeitoSistemico efeitoSistemico)
        {
            ConfereFrequenciaCardiaca(parametros, efeitoSistemico);
            ConfereFrequenciaRespiratoria(parametros, efeitoSistemico);
            ConferePressaoArterial(parametros, efeitoSistemico);
            ConfereHematocritos(parametros, efeitoSistemico);
            ConfereLeucocitos(parametros, efeitoSistemico);
        }

        public void ConfereFrequenciaCardiaca(Parametros parametros, EfeitoSistemico efeitoSistemico)
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
        public void ConfereFrequenciaRespiratoria(Parametros parametros, EfeitoSistemico efeitoSistemico)
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

        public void ConferePressaoArterial(Parametros parametros, EfeitoSistemico efeitoSistemico)
        {
            if(efeitoSistemico.PodeAumentarPressaoArterial == true)
            {
                parametros.PressaoArterialSistemica = "AUMENTOU";
            }
            else if (efeitoSistemico.PodeDiminuirPressaoArterial == true)
            {
                parametros.PressaoArterialSistemica = "DIMINUIU";
            }
            else { return; }
        }

        public void ConfereHematocritos(Parametros parametros, EfeitoSistemico efeitoSistemico)
        {
            if(efeitoSistemico.PodeAumentarHematocritos == true)
            {
                parametros.Hematocrito = "AUMENTOU";
            }

            else if (efeitoSistemico.PodeDiminuirHematocritos == true)
            {
                parametros.Hematocrito = "DIMINUIU";
            }
            else { return; }
        }

        public void ConfereLeucocitos(Parametros parametros, EfeitoSistemico efeitoSistemico)
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
