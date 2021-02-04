using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SitePessoal.Models
{
    public class Escolas
    {
        public int EscolasId { get; set; }
        public string Escola { get; set; }
        public string Curso { get; set; }
        [Display(Name = "Nota Final")]
        public int Nota { get; set; }
        public byte[] Foto { get; set; }
    }
}
