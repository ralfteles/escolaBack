using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEscola.API.ViewModel
{
    public class TurmaViewModel
    {
        public Guid Id { get; set; }
        public string nome { get; set; }
        public int vagas { get; set; }
        public Guid escolaId { get; set; }
    }
}
