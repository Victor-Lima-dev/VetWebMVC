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


        //Metodos para aplicar os efeitos do remedio

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
