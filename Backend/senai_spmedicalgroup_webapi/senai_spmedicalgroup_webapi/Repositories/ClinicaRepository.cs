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
            //Busca uma clinica 
            Clinica clinicabuscada = BuscarPorId(id);

            if (novaClinicaAtual.Nome!= null)
            {
                //Atribui novos valores aos campos existentes
                clinicabuscada.Nome = novaClinicaAtual.Nome;
            }
            //Atualiza uma clinica que foi buscada 
            ctx.Clinicas.Update(clinicabuscada);
            //Salva as informações para serem salvas no Banco de dados
            ctx.SaveChanges();
        }

        public Clinica BuscarPorId(int id)
        {
            //Retorna a primeira clinica para o id informado
            return ctx.Clinicas.FirstOrDefault(cli => cli.IdClinica == id);
        }

        public void Cadastrar(Clinica novaClinica)
        {
            ctx.Clinicas.Add(novaClinica);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            //Busca uma clinica
            Clinica clinicabuscada = BuscarPorId(id);
            //Remove a clinica buscada
            ctx.Clinicas.Remove(clinicabuscada);
            //Salva as alterações
            ctx.SaveChanges();
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
