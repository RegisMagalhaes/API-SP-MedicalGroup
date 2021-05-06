using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_spmedicalgroup_webapi.Domains;
using senai_spmedicalgroup_webapi.Interfaces;
using senai_spmedicalgroup_webapi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
    /// <summary>
    /// Controller responsável pelos endpoints (URL) referentes as requisições para Clinicas
    /// </summary>
namespace senai_spmedicalgroup_webapi.Controllers
{
    //Define que o tipo de resposta da API será no formato Json

    [Produces("application/json")]
    //Define a rota de uma requisição, sendo neste formato:dominio/api/nomeController

    //ex: https://localhost:5000/api/Clinicas

    [Route("api/[controller]")]
    //Define que é um controlador de APi

    [ApiController]
    public class ClinicasController : ControllerBase
    {
        private IClinicaRepository _clinicaRepository { get; set; }

        /// <summary>
        /// instancia o objeto _clinicaRepository para que haja referencia aos métodos no repositorio
        /// </summary>
        public ClinicasController()
        {
            
            _clinicaRepository = new ClinicaRepository();
        }

        /// <summary>
        /// Lista todos os tipos de Clinicas e um status code 200
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                //Retorna a resposta da requisição fazendo a chamada para o método
                return Ok(_clinicaRepository.ListarTodos());
            }
            catch (Exception ex)
            {
                //Retorna a exception e um status code 400 do tipo BadRequest
                return BadRequest(ex);
            }
        }
        /// <summary>
        /// Busca um tipo de Clinica pelo seu Id
        /// </summary>
        /// <param name="id">id da clinica que será buscada</param>
        /// <returns>uma clinica buscada e um status code</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                //Retorna a resposta da requisição fazendo a chamada para o método
                return Ok(_clinicaRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                //Retorna a exception e um status code 400 - Bad Request
                return BadRequest(ex);
            }
        }
        /// <summary>
        /// Cadastra uma nova Clinica 
        /// </summary>
        /// <param name="novaClinica">nova clinica a ser cadastrada </param>
        /// <returns>retornando um status code</returns>
        [HttpPost]
        public IActionResult Post(Clinica novaClinica)
        {
            try
            {
                //Faz a chamada para o método
                _clinicaRepository.Cadastrar(novaClinica);
                //Retorna um Status Code 201
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                //retorna a exception e um status code 400
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Atualiza uma clinica existente
        /// </summary>
        /// <param name="id">id da clinica que será atualizada</param>
        /// <param name="novaClinicaAtualizada">objeto com as novas informações </param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Clinica novaClinicaAtualizada)
        {
            try
            {
                //Faz a chamada para o método
                _clinicaRepository.Atualizar(id, novaClinicaAtualizada);
                //retorna um status code
                return StatusCode(204);
            }
            catch (Exception ex )
            {

                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _clinicaRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
