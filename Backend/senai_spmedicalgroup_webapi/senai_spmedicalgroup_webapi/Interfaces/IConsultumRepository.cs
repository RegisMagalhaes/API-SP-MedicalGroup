using senai_spmedicalgroup_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo Repositório ConsultaRepository
    /// </summary>
    interface IConsultumRepository
    {
        /// <summary>
        /// Lista todas as Consultas
        /// </summary>
        /// <returns>Retorna uma lista de consulta</returns>
        List<Consultum> ListarTodas();


        /// <summary>
        /// Busca uma consulta pelo seu Id
        /// </summary>
        /// <param name="id">Id da consulta buscada</param>
        /// <returns>Retorna o objeto consulta</returns>
        Consultum BuscarPorId(int id);

        /// <summary>
        /// Cadastra uma nova Consulta
        /// </summary>
        /// <param name="novaConsulta">objeto Nova Consulta que será cadastrada</param>
        void Cadastrar(Consultum novaConsulta);

        /// <summary>
        /// Atualiza uma nova consulta buscada
        /// </summary>
        /// <param name="id">id da nova consulta atualizada</param>
        /// <param name="novaConsultaAtual">objeto nova consulta atual</param>
        void Atualizar(int id, Consultum novaConsultaAtual);

        /// <summary>
        /// Deleta uma consulta
        /// </summary>
        /// <param name="id">id da consulta deletada</param>
        void Deletar(int id);
    }
}
