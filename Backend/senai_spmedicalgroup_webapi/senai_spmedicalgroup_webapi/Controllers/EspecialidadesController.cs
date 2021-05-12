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
    [Produces ("application/json")]

    //Define a rota de um requisição sendo neste formato: dominio/api/
    [Route("api/[controller]")]
    [ApiController]

    //Objeto que irá receber os métodos definidos na interface IEspecialidadeRepository
   
    public class EspecialidadesController : ControllerBase
    {
       private IEspecialidadeRepository _especialidadeRepository { get; set; }

        public EspecialidadesController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }

        /// <summary>
        /// Lista todas as Especialidades
        /// </summary>

        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                //retorna a resposta da requisição fazendo a chamada para o método
                return Ok(_especialidadeRepository.ListaTodas());
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

        public IActionResult GetById (int id)
        {
            try
            {
                return Ok(_especialidadeRepository.BuscarPorId(id));
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

        public IActionResult Post(Especialidade novaEspecialidade)
        {
            try
            {
                 _especialidadeRepository.Cadastrar(novaEspecialidade);

                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpPut("{id})")]

        public IActionResult Put(int id, Especialidade especialidadeAtualizada)
        {
            try
            {
                _especialidadeRepository.Atualizar(id, especialidadeAtualizada);

                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpDelete("{id})")]

        public IActionResult Delete(int id)
        {
            try
            {
                _especialidadeRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}
