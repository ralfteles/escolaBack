using ProjetoEscola.Aplicacao.Aplicacao.Base;
using ProjetoEscola.Aplicacao.Interface;
using ProjetoEscola.Dominio.Entidade;
using ProjetoEscola.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Aplicacao.Aplicacao
{
    public class TurmaApplication : Application<Turma>, ITurmaApplication
    {
        private readonly ITurmaRepository _turmaRepository;
        public TurmaApplication(ITurmaRepository turmaRepository) : base(turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }

        public async Task<IEnumerable<Turma>> ObterTurmasDaEscola(Guid idEscola)
        {
            return await _turmaRepository.ObterTurmasDaEscola(idEscola);
        }
    }
}
