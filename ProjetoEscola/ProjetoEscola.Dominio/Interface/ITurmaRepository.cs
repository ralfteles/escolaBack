using ProjetoEscola.Dominio.Entidade;
using ProjetoEscola.Dominio.Interface.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Dominio.Interface
{
    public interface ITurmaRepository : IRepository<Turma>
    {
        public Task<IEnumerable<Turma>> ObterTurmasDaEscola(Guid idEscola);
    }
}
