using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public ClinicasController()
        {
            

            _clinicaRepository = new ClinicaRepository();
        }
    }
}
