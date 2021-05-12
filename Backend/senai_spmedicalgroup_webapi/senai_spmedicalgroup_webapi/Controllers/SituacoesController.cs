using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_spmedicalgroup_webapi.Domains;
using senai_spmedicalgroup_webapi.Interfaces;
using senai_spmedicalgroup_webapi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Controllers
{
    /// <summary>
    /// Define que a resposta da requisição será no formato json
    /// </summary>
    [Produces("application/json")]

    //Define a rota da requisição
    [Route("api/[controller]")]
    [ApiController]

    //objeto que irá receber os métodos declarados na interface
    public class SituacoesController : ControllerBase
    {
        private ISituacaoRepository _situacaoRepository { get; set; }

        public SituacoesController()
        {
            _situacaoRepository = new SituacaoRepository();
        }

        /// <summary>
        /// Lista todos os pacientes
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                //retorna a resposta da requisição fazendo a chamada para o método
                return Ok(_situacaoRepository.Listar());
            }
            catch (Exception ex)
            {
                //retorna uma bad request da exception
                return BadRequest(ex);
            }

        }
        /// <summary>
        /// Busca todas as especiaidades por id
        /// </summary>
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_situacaoRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
        /// <summary>
        /// Cadastra todas as especialidades
        /// </summary>
        /// <param name="novaEspecialidade"></param>
        /// <returns></returns>

        [HttpPost]

        public IActionResult Post(Situacao novaSituacao)
        {
            try
            {
                _situacaoRepository.Cadastrar(novaSituacao);
                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Atualiza os paclentes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="especialidadeAtualizada"></param>
        /// <returns></returns>
        [HttpPut("{id})")]

        public IActionResult Put(int id, Situacao situacaoAtualizada)
        {
            try
            {
                _situacaoRepository.Atualizar(id, situacaoAtualizada);

                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }



        }
        /// <summary>
        /// Deleta um paciente do sistema
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id})")]

        public IActionResult Delete(int id)
        {
            try
            {
                _situacaoRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}
