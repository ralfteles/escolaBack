using ProjetoEscola.Aplicacao.Interface.Base;
using ProjetoEscola.Dominio.Interface.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Aplicacao.Aplicacao.Base
{
    public class Application<TEntity> : IAppApplication<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public Application(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public void Adicionar(TEntity obj)
        {
            _repository.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _repository.Atualizar(obj);
        }

        public void Excluir(TEntity obj)
        {
            _repository.Excluir(obj);
        }

        public async Task<TEntity> ObterPorId(Guid Id)
        {
            return await _repository.ObterPorId(Id);
        }

        public async Task<IEnumerable<TEntity>> ObterTodos()
        {
            return await _repository.ObterTodos();
        }
    }
}
