using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitePessoal.Models
{
    public class Escola
    {
        public int EscolaId { get; set; }
        public string NomeEscola { get; set; }

        public DateTime DataFim { get; set; }
    }
}
