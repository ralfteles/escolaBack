using Microsoft.Extensions.DependencyInjection;
using ProjetoEscola.Aplicacao.Aplicacao;
using ProjetoEscola.Aplicacao.Interface;
using ProjetoEscola.Dominio.Interface;
using ProjetoEscola.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEscola.API
{
    public class DependecyInjection
    {
        public static void RegistrarServicos(IServiceCollection services)
        {
            services.AddScoped<IEscolaApplication, EscolaApplication>();
            services.AddScoped<ITurmaApplication, TurmaApplication>();

            services.AddScoped<IEscolaRepository, EscolaRepository>();
            services.AddScoped<ITurmaRepository, TurmaRepository>();
        }

      
    }
}
