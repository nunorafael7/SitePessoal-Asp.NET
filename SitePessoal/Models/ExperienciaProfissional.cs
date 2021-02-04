using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SitePessoal.Models
{
    public class ExperienciaProfissional
    {
        public int ExperienciaProfissionalId { get; set; }
        public string Trabalho { get; set; }
        [Display(Name = "Duração")]
        public string Duracao { get; set; }
        [Display(Name = "Função")]
        public string Funcao { get; set; }

    }
}
