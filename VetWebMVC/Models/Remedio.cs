﻿using System;
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
        public EfeitoSistemico EfeitoSistemico { get; set; }

        public Remedio(string nome, string principioAtivo, string mecanismoAcao, string viaAdministracao, string efeitoAdverso, EfeitoSistemico efeitoSistemico)
        {
            Nome = nome;
            PrincipioAtivo = principioAtivo;
            MecanismoAcao = mecanismoAcao;
            ViaAdministracao = viaAdministracao;
            EfeitoAdverso = efeitoAdverso;
            EfeitoSistemico = efeitoSistemico;
        }
    }

    
}