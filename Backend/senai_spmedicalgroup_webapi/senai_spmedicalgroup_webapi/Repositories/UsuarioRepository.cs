using senai_spmedicalgroup_webapi.Contexts;
using senai_spmedicalgroup_webapi.Domains;
using senai_spmedicalgroup_webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        spmedicalgroupContext ctx = new spmedicalgroupContext();

 

        public void Atualizar(int id, Usuario novoUsuarioAtual)
        {
            Usuario usuarioBuscado = BuscarPorId(id);

            if (novoUsuarioAtual.Email != null)
            {
                usuarioBuscado.Email = novoUsuarioAtual.Email;
            }
            ctx.Usuarios.Update(usuarioBuscado);

            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(us => us.IdUsuario == id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarTodos()
        {
            return ctx.Usuarios.ToList();
        }
    }
}
