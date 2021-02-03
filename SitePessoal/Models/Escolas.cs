using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitePessoal.Models
{
    public class Escolas
    {
        public int EscolasId { get; set; }
        public string Escola { get; set; }
        public string Curso { get; set; }
        public int Nota { get; set; }
        public byte[] Foto { get; set; }
    }
}
