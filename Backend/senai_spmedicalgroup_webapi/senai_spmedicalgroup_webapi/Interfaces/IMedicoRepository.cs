using senai_spmedicalgroup_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo Repositório MedicoRepository
    /// </summary>
    interface IMedicoRepository
    {
        /// <summary>
        /// Lista todos os medicos
        /// </summary>
        /// <returns>Retorna uma lista de médicos</returns>
        List<Medico> ListarTodos();

        /// <summary>
        /// Busca um médico pelo seu id
        /// </summary>
        /// <param name="id">ID do médico buscado</param>
        /// <returns>retorna um objeto medico pelo numero de id cadastrado</returns>
        Medico BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo medico
        /// </summary>
        /// <param name="novoMedico"></param>
        void Cadastrar(Medico novoMedico);

        /// <summary>
        /// Atualiza 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="novoMedicoAtual"></param>
        void Atualizar(int id, Medico novoMedicoAtual);

        /// <summary>
        /// Deleta um médico do sistema através do seu ID
        /// </summary>
        /// <param name="id">id do medico a ser deletado do sistema</param>
        void Deletar(int id);

    }
}
