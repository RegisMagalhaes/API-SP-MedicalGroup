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
        //Define que o tipo de resposta da API será no formato Json

    [Produces("application/json")]
    //Define a rota de uma requisição, sendo neste formato:dominio/api/
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        //Objeto que irá receber todos os métodos definidos na interface IConsultum Repository
        private IConsultumRepository _consultaRepository { get; set; }

        public ConsultasController()
        {
            _consultaRepository = new ConsultumRepository();
                    
        }
        /// <summary>
        /// Lista todas as consultas
        /// </summary>
        /// <returns>uma lista de consultas e um status code</returns>
        [HttpGet]

        public IActionResult Get()
        {
            try
            {   
                //retorna a resposta da requisição fazendo a chamada para o método
                return Ok(_consultaRepository.ListarTodas());
            }
            catch (Exception ex)
            {
                //retorna a exception e um status code 400 - BadRequest
                return BadRequest(ex);
            }


        }
        /// <summary>
        /// Busca uma consulta através do seu ID
        /// </summary>
        /// <param name="id">id da consulta que será buscada</param>
        /// <returns>uma consulta buscada e um status code</returns>
        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            try
            {
                //retorna a resposta da requisição fazendo a chamada pelo método e um status code 200
                return Ok(_consultaRepository.BuscarPorId(id));

            }
            catch (Exception ex)
            {
                //Retorna a exception e um status code 400 
                return BadRequest(ex);
            }
        }
        /// <summary>
        /// Cadastra uma nova consulta 
        /// </summary>
        /// <param name="novaConsulta">parâmetro de invocação</param>
        /// <returns>retorna um status code 201</returns>
        [HttpPost]

        public IActionResult Post(Consultum novaConsulta)
        {
            try
            {
                //Faz a chamada para o método 
                _consultaRepository.Cadastrar(novaConsulta);
                //retorna um status code
                return StatusCode(201);
            }
            catch (Exception ex)
            {

                //Retorna a exception e um status code 400 
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, Consultum consultaAtualizada)
        {
            try
            {
                //Faz a chamada para o metodo 
                _consultaRepository.Atualizar(id, consultaAtualizada);
                // retorna um status code 
                return StatusCode(204);

            }
            catch (Exception ex)
            {
                //Retorna a Bad Request
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                //Faz a chamada para o metodo 
                _consultaRepository.Deletar(id);
                //retorna um status code
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                //Retorna uma Bad Request da Exception
                return BadRequest(ex);
            }
        }
    }
}
