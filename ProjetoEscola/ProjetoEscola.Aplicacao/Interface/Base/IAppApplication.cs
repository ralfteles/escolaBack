using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Aplicacao.Interface.Base
{
    public interface IAppApplication<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> ObterTodos();
        Task<TEntity> ObterPorId(Guid Id);
        void Atualizar(TEntity obj);
        void Adicionar(TEntity obj);
        void Excluir(TEntity obj);
    }
}
