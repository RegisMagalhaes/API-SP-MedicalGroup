using senai_spmedicalgroup_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo Repositório PacienteRepository
    /// </summary>
    interface IPacienteRepository
    {
        /// <summary>
        /// Lista todos os pacientes no sistema
        /// </summary>
        /// <returns>retorna uma lista de pacientes</returns>
        List<Paciente> ListarTodos();

        /// <summary>
        /// Busca um paciente através do número do id
        /// </summary>
        /// <param name="id">id do paciente buscado</param>
        /// <returns>retorna um paciente através do id</returns>
        Paciente BuscarPorId(int id);


     /// <summary>
     /// Cadastra um novo paciente
     /// </summary>
     /// <param name="novoPaciente">objeto novo paciente</param>
        void Cadastrar(Paciente novoPaciente);

        /// <summary>
        /// Atualiza um paciente
        /// </summary>
        /// <param name="id">id do paciente atualizado</param>
        /// <param name="novoPacienteAtual"></param>
        void Atualizar(int id, Paciente novoPacienteAtual);

        /// <summary>
        /// Deleta o paciente do sistema
        /// </summary>
        /// <param name="id">id do paciente a ser deletado</param>
        void Deletar(int id);
    }
}
