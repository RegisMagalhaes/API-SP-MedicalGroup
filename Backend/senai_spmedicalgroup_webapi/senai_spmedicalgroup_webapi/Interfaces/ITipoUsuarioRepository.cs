using senai_spmedicalgroup_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo Repositório TipoUsuarioRepository
    /// </summary>
    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Lista todos os tipos de Usuarios cadastrados no sistema
        /// </summary>
        /// <returns></returns>
        List<TipoUsuario> ListarTodosTipos();

    }
}
