using senai_spmedicalgroup_webapi.Contexts;
using senai_spmedicalgroup_webapi.Domains;
using senai_spmedicalgroup_webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        spmedicalgroupContext ctx = new spmedicalgroupContext();
        public List<TipoUsuario> ListarTodosTipos()
        {
            return ctx.TipoUsuarios.ToList();
        }
    }
}
