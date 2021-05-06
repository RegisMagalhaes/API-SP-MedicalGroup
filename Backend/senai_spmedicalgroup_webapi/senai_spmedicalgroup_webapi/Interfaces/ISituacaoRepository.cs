using senai_spmedicalgroup_webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo Repositório SituacaoRepository
    /// </summary>
    interface ISituacaoRepository
    {
        /// <summary>
        /// Lista todas as situações dos pacientes
        /// </summary>
        /// <returns>retorna uma lista de tipos de situações</returns>
        List<Situacao> Listar();

        /// <summary>
        /// Busca uma situação por id no sistema
        /// </summary>
        /// <param name="id">id da situacao buscada</param>
        /// <returns>retorna um objeto de situacao</returns>
        Situacao BuscarPorId(int id);

        
        void Cadastrar(Situacao novaSituacao);

        /// <summary>
        /// Atualiza uma nova situação
        /// </summary>
        /// <param name="id"></param>
        /// <param name="novaSituacaoAtual"></param>
        void Atualizar(int id, Situacao novaSituacaoAtual);

        /// <summary>
        /// Deleta uma situacao
        /// </summary>
        /// <param name="id"></param>
        void Deletar(int id);


    }
}
