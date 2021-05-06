using senai_spmedicalgroup_webapi.Contexts;
using senai_spmedicalgroup_webapi.Domains;
using senai_spmedicalgroup_webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositório da Clinica
    /// </summary>
    public class ClinicaRepository : IClinicaRepository
    {

        spmedicalgroupContext ctx = new spmedicalgroupContext();
        public void Atualizar(int id, Clinica novaClinicaAtual)
        {
            throw new NotImplementedException();
        }

        public Clinica BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Clinica novaClinica)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista todas as Clinicas
        /// </summary>
        /// <returns>Retorna uma lista de Clínicas</returns>
        public List<Clinica> ListarTodos()
        {
            //Return a list with all information from Cinica
            return ctx.Clinicas.ToList();
        }
    }
}
