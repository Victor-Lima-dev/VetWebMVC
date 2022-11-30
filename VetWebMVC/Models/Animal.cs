using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetWeb
{
    public class Animal
    {
        public string Nome { get; set; }
        public int AnimalId { get; set; }
        public string FaseDaVida { get; set; }

        public string Sexo { get; set; }
        public string Comorbidade { get; set; }
        public string Condicao { get; set; }
        public Parametros Parametros { get; set; }

        public Animal(string nome, string faseDaVida, string sexo, string comorbidade, string condicao, Parametros parametros)
        {
            Nome = nome;
            FaseDaVida = faseDaVida;
            Sexo = sexo;
            Comorbidade = comorbidade;
            Condicao = condicao;
            Parametros = parametros;
        }


    }
}
