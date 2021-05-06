using senai_spmedicalgroup_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo Repositório ClinicaRepository
    /// </summary>
    interface IClinicaRepository
    {
        //Definição de Métodos, segue a estrutura;
        //tipoRetorno nomeMetodo(tipo parametro, nomeParametro);

        /// <summary>
        /// Lista todas as Clinicas
        /// </summary>
        /// <returns>Retorna uma lista de Clínicas</returns>
        List<Clinica> ListarTodos();

        /// <summary>
        /// Busca uma clinica através do seu Id
        /// </summary>
        /// <param name="id">Id do tipo de Clinica que sera buscado</param>
        /// <returns>Retorna um Id encontrado</returns>
        Clinica BuscarPorId(int id);

        /// <summary>
        /// Cadastra uma nova clinica
        /// </summary>
        /// <param name="novaClinica">Objeto Nova Clinica que será cadastrada</param>
        void Cadastrar(Clinica novaClinica);

        /// <summary>
        /// Atualiza a nova Clinica no sistema
        /// </summary>
        /// <param name="id">id da clinica que será atualizada</param>
        /// <param name="novaClinicaAtual">Devolve o objeto novaClinicaAtual</param>
        void Atualizar(int id, Clinica novaClinicaAtual);


        /// <summary>
        /// Deleta uma clinica pelo seu ID
        /// </summary>
        /// <param name="id">id da clinica que será deletada</param>
        void Deletar(int id);



        }
}
