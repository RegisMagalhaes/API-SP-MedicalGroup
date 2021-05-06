using senai_spmedicalgroup_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo Repositório UsuarioRepository
    /// </summary>
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos os Usuarios do Sistema
        /// </summary>
        /// <returns>Retorna uma lista de usuarios do sistema</returns>
        List<Usuario> ListarTodos();

        /// <summary>
        /// Busca um Usuario pelo seu id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Usuario BuscarPorId(int id);

        /// <summary>
        /// Cadastra um usuario
        /// </summary>
        /// <param name="novoUsuario">objeto novo usuario</param>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Atualiza um usuario do sistema
        /// </summary>
        /// <param name="novoUsuarioAtual">objeto usuario</param>
        void Atualizar(Usuario novoUsuarioAtual);

        /// <summary>
        /// Deleta um usuario do sistema
        /// </summary>
        /// <param name="id"></param>
        void Deletar(int id);
    }
}
