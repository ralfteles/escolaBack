using ProjetoEscola.Aplicacao.Aplicacao.Base;
using ProjetoEscola.Aplicacao.Interface;
using ProjetoEscola.Aplicacao.Interface.Base;
using ProjetoEscola.Dominio.Entidade;
using ProjetoEscola.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Aplicacao.Aplicacao
{
    public class EscolaApplication : Application<Escola>, IEscolaApplication
    {
        private readonly IEscolaRepository _escolaRepository;
        public EscolaApplication(IEscolaRepository escolaRepository) : base(escolaRepository)
        {
            _escolaRepository = escolaRepository;
        }
        
    }
}
