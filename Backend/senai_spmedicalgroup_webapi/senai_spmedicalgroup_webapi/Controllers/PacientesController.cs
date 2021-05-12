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
    public class PacientesController : ControllerBase
    {
        private IPacienteRepository _pacienteRepository { get; set; }

        public PacientesController()
        {
            _pacienteRepository = new PacienteRepository();
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
                return Ok(_pacienteRepository.ListarTodos());
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
                return Ok(_pacienteRepository.BuscarPorId(id));
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

        public IActionResult Post(Paciente novoPaciente)
        {
            try
            {
                _pacienteRepository.Cadastrar(novoPaciente);

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

        public IActionResult Put(int id, Paciente pacienteatual)
        {
            try
            {
                _pacienteRepository.Atualizar(id, pacienteatual);

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
                _pacienteRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }


    }
}
