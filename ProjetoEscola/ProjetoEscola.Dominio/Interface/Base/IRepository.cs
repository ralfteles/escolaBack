using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Dominio.Interface.Base
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> ObterTodos();
        Task<TEntity> ObterPorId(Guid Id);
        void Atualizar(TEntity obj);
        void Adicionar(TEntity obj);
        void Excluir(TEntity obj);
    }
}
