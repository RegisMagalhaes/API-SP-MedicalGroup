using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        
    }
}
