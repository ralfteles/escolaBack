using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEscola.API.ViewModel;
using ProjetoEscola.Aplicacao.Interface;
using ProjetoEscola.Dominio.Entidade;

namespace ProjetoEscola.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {

        private readonly ITurmaApplication _turmaApplication;
        private readonly IMapper _mapper;
        public TurmaController(ITurmaApplication turmaApplication, IMapper mapper)
        {
            _turmaApplication = turmaApplication;
            _mapper = mapper;
        }
        [HttpGet("ObterTurmas")]
        public async Task<IEnumerable<TurmaViewModel>> ObterTurmas()
        {
            return _mapper.Map<IEnumerable<TurmaViewModel>>(await _turmaApplication.ObterTodos());
        }

        [HttpGet("ObterTurmaPorId")]
        public async Task<TurmaViewModel> ObterTurmaPorId(Guid id)
        {
            return _mapper.Map<TurmaViewModel>(await _turmaApplication.ObterPorId(id));
        }

        [HttpGet("ObterTurmasDaEscola")]
        public async Task<IEnumerable<TurmaViewModel>> ObterTurmasDaEscola(Guid idEscola)
        {
            return _mapper.Map<IEnumerable<TurmaViewModel>>(await _turmaApplication.ObterTurmasDaEscola(idEscola));
        }


        [HttpPost("AdicionarTurma")]
        public IActionResult AdicionarTurma(TurmaViewModel escola)
        {
            try
            {
                var escolaEntity = _mapper.Map<Turma>(escola);
                _turmaApplication.Adicionar(escolaEntity);

                return Ok(new StatusServer("Turma adicionada com sucesso!"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AtualizarEscola")]
        public IActionResult AtualizarEscola(TurmaViewModel escola)
        {
            try
            {
                var turmaEntity = _mapper.Map<Turma>(escola);
                _turmaApplication.Atualizar(turmaEntity);

                return Ok("Turma atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("RemoverEscola")]
        public async Task<IActionResult> RemoverEscola(Guid id)
        {
            try
            {
                var turma = await _turmaApplication.ObterPorId(id);
                _turmaApplication.Excluir(turma);

                return Ok("Turma removida com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}