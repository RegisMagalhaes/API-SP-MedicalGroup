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
    /// Define que o tipo de resposta da API será no formato json
    /// </summary>
    [Produces("application/json")]

    
    //Define a rota da requisição
    [Route("api/[controller]")]


    [ApiController]
    public class MedicosController : ControllerBase
    {
        private IMedicoRepository _medicoRepository { get; set; }

        /// <summary>
        /// Objeto que irá receber os métodos definidos na interface IMedicosRepository
        /// </summary>
        public MedicosController()
        {
            _medicoRepository = new MedicoRepository();
        }

        /// <summary>
        /// Lista todos os médicos
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        public IActionResult Get()
        {
            try
            {
               return Ok(_medicoRepository.ListarTodos());
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
        /// <summary>
        /// Busca médicos pelo seu Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            try
            {

                return Ok(_medicoRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
        /// <summary>
        /// Cadastra um novo médico no sistema
        /// </summary>
        /// <param name="novoMedico"></param>
        /// <returns></returns>
        [HttpPost]

        public IActionResult Post(Medico novoMedico)
        {
            try
            {
                _medicoRepository.Cadastrar(novoMedico);

                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
        /// <summary>
        /// Atualiza um medico no sistema
        /// </summary>
        /// <param name="id"></param>
        /// <param name="medicoAtual"></param>
        /// <returns></returns>
        [HttpPut]

        public IActionResult Put(int id, Medico medicoAtual)
        {
            try
            {
                _medicoRepository.Atualizar(id, medicoAtual);

                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
        public IActionResult Delete(int id)
        {
            try
            {
                _medicoRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}
