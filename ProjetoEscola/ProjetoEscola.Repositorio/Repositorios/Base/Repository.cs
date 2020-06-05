using Microsoft.EntityFrameworkCore;
using ProjetoEscola.Dominio.Interface.Base;
using ProjetoEscola.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Repositorio.Repositorios.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly EscolaContext _escolaContext;
        public Repository()
        {
            _escolaContext = new EscolaContext();
        }
        public void Adicionar(TEntity obj)
        {
            _escolaContext.Set<TEntity>().Add(obj);
            _escolaContext.SaveChanges();
        }

        public void Atualizar(TEntity obj)
        {
            _escolaContext.Entry(obj).State = EntityState.Modified;
            _escolaContext.SaveChanges();
        }

        public void Excluir(TEntity obj)
        {
            _escolaContext.Set<TEntity>().Remove(obj);
            _escolaContext.SaveChanges();
        }

        public async Task<TEntity> ObterPorId(Guid Id)
        {
            return await _escolaContext.Set<TEntity>().FindAsync(Id);
        }

        public async Task<IEnumerable<TEntity>> ObterTodos()
        {
            return await _escolaContext.Set<TEntity>().ToListAsync();
        }
        public void Dispose()
        {
            _escolaContext?.Dispose();
        }
    }
}
