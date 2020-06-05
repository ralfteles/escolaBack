using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEscola.API
{
    public class StatusServer
    {
        public string mensagem { get; set; }
        public StatusServer(string mensagem)
        {
            this.mensagem = mensagem;
        }
    }
}
