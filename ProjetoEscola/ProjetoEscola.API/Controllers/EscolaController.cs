using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjetoEscola.API.ViewModel;
using ProjetoEscola.Aplicacao.Interface;
using ProjetoEscola.Dominio.Entidade;

namespace ProjetoEscola.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaApplication _escolaApplication;
        private readonly IMapper _mapper;
        public EscolaController(IEscolaApplication escolaApplication, IMapper mapper)
        {
            _escolaApplication = escolaApplication;
            _mapper = mapper;
        }
        [HttpGet("ObterEscolas")]
        public async Task<IEnumerable<EscolaViewModel>> ObterEscolas()
        {
            return _mapper.Map<IEnumerable<EscolaViewModel>>(await _escolaApplication.ObterTodos());
        }

        [HttpGet("ObterEscolaPorId")]
        public async Task<EscolaViewModel> ObterEscolaPorId(Guid id)
        {
            return _mapper.Map<EscolaViewModel>(await _escolaApplication.ObterPorId(id));
        }


        [HttpPost("AdicionarEscola")]
        public IActionResult AdicionarEscola([FromBody] EscolaViewModel escolaVm)
        {
            try
            {
                var escolaEntity = _mapper.Map<Escola>(escolaVm);
                _escolaApplication.Adicionar(escolaEntity);

                return Ok( new StatusServer($"Escola {escolaVm.descricao} adicionada com sucesso!"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AtualizarEscola")]
        public IActionResult AtualizarEscola(EscolaViewModel escola)
        {
            try
            {
                var escolaEntity = _mapper.Map<Escola>(escola);
                _escolaApplication.Atualizar(escolaEntity);

                return Ok("Escola atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("RemoverEscola")]
        public async Task<ActionResult> RemoverEscola(Guid id)
        {
            try
            {
                var escola = await _escolaApplication.ObterPorId(id);
                _escolaApplication.Excluir(escola);

                return Ok("Escola removida com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
}


}