using AutoMapper;
using ProjetoEscola.API.ViewModel;
using ProjetoEscola.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEscola.API.Configuracao
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {

            CreateMap<Escola, EscolaViewModel>();
            CreateMap<EscolaViewModel, Escola>()
                      .ConstructUsing(escolaVm => new Escola(escolaVm.descricao));

            CreateMap<Turma, TurmaViewModel>();
            CreateMap<TurmaViewModel, Turma>()
                      .ConstructUsing(turmaVm => new Turma(turmaVm.nome, turmaVm.vagas, turmaVm.escolaId));
        }
    }
}
