using Microsoft.EntityFrameworkCore;
using ProjetoEscola.Dominio.Entidade;
using ProjetoEscola.Dominio.Interface;
using ProjetoEscola.Repositorio.Contexto;
using ProjetoEscola.Repositorio.Repositorios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Repositorio.Repositorios
{
    public class TurmaRepository : Repository<Turma>, ITurmaRepository
    {
        public async Task<IEnumerable<Turma>> ObterTurmasDaEscola(Guid idEscola)
        {
            return await _escolaContext.Turma.Where(t => t.EscolaId == idEscola).ToListAsync();
        }
    }
}
