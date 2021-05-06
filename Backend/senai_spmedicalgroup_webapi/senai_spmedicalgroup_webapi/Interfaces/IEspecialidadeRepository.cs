using senai_spmedicalgroup_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo Repositório EspecialidadeRepository
    /// </summary>
    interface IEspecialidadeRepository
    {
        /// <summary>
        /// Lista todas as especialidades
        /// </summary>
        /// <returns>Retorna uma lista de especialidades</returns>
        List<Especialidade> ListaTodas();

        /// <summary>
        /// Busca uma especialidade médica pelo seu ID
        /// </summary>
        /// <param name="id">Id da especialidade buscada</param>
        /// <returns>Retorna um objeto Especilidade</returns>
        Especialidade BuscarPorId(int id);

        /// <summary>
        /// Cadastra novas especialidades
        /// </summary>
        /// <param name="novaEspecialidade">objeto nova especialidade a ser cadastrada</param>
        void Cadastrar(Especialidade novaEspecialidade);

        /// <summary>
        /// Atualiza uma nova especialidade
        /// </summary>
        /// <param name="id">id da especialidade a ser atualizada</param>
        /// <param name="novaEspecialidadeAtual">objeto nova Especialidade a ser atualizada</param>
        void Atualizar(int id, Especialidade novaEspecialidadeAtual);

        /// <summary>
        /// Deleta a especialidade através do seu id
        /// </summary>
        /// <param name="id">id do objeto a ser deletado</param>
        void Deletar(int id);


    }
}
