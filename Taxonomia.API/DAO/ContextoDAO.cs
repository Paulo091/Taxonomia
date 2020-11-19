using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taxonomia.API.Context;
using Taxonomia.API.Models;

namespace Taxonomia.API.DAO
{
    public class ContextoDAO<TDbContext> where TDbContext : DbContext
    {
        private TDbContext _contexto { get; }

        public ContextoDAO(TDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<int> InserirAsync<TEntity>(TEntity objeto) where TEntity : class
        {
            int retorno = 0;
            using(_contexto)
            {
                _contexto.Set<TEntity>().Add(objeto);
                retorno = await SalvarAlteracoesAsync(_contexto);
            }
            return retorno;
        }

        public async Task<int> AlterarAsync<TEntity>(TEntity objeto) where TEntity : class
        {
            int retorno = 0;
            using (_contexto)
            {
                _contexto.Set<TEntity>().Update(objeto);
                retorno = await SalvarAlteracoesAsync(_contexto);
            }
            return retorno;
        }

        public async Task<int> AlterarColecaoAsync<TEntity>(IEnumerable<TEntity> objeto) where TEntity : class
        {
            int retorno = 0;
            using (_contexto)
            {
                _contexto.Set<TEntity>().UpdateRange(objeto);
                retorno = await SalvarAlteracoesAsync(_contexto);
            }
            return retorno;
        }

        public async Task<int> ExcluirAsync<TEntity>(TEntity objeto) where TEntity : class
        {
            int retorno = 0;
            using (_contexto)
            {
                _contexto.Set<TEntity>().Remove(objeto);
                retorno = await SalvarAlteracoesAsync(_contexto);
            }
            return retorno;
        }

        public async Task<int> ExcluirColecaoAsync<TEntity>(IEnumerable<TEntity> objeto) where TEntity : class
        {
            int retorno = 0;
            using (_contexto)
            {
                _contexto.Set<TEntity>().RemoveRange(objeto);
                retorno = await SalvarAlteracoesAsync(_contexto);
            }
            return retorno;
        }

        private async Task<int> SalvarAlteracoesAsync(TDbContext contexto)
        {
            return await _contexto.SaveChangesAsync();
        }
    }
}
