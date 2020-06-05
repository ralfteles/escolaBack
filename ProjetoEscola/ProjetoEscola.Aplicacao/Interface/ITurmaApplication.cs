using ProjetoEscola.Aplicacao.Interface.Base;
using ProjetoEscola.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Aplicacao.Interface
{
    public interface  ITurmaApplication : IAppApplication<Turma>
    {
        public Task<IEnumerable<Turma>> ObterTurmasDaEscola(Guid idEscola);
    }
}
