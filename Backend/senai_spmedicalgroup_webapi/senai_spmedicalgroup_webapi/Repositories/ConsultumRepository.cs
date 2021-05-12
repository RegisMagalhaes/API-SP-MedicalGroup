using senai_spmedicalgroup_webapi.Contexts;
using senai_spmedicalgroup_webapi.Domains;
using senai_spmedicalgroup_webapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_spmedicalgroup_webapi.Repositories
{
    public class ConsultumRepository : IConsultumRepository
    {
        spmedicalgroupContext ctx = new spmedicalgroupContext();
        public void Atualizar(int id, Consultum novaConsultaAtual)
        {
            Consultum consultaBuscada = BuscarPorId(id);

            if (novaConsultaAtual.Prontuario != null)
            {
                consultaBuscada.Prontuario = novaConsultaAtual.Prontuario;
            }

            ctx.Consulta.Update(consultaBuscada);

            ctx.SaveChanges();
        }

        public Consultum BuscarPorId(int id)
        {
            //Retorna a primeira consulta para o ID informado
            return ctx.Consulta.FirstOrDefault(cli => cli.Idconsulta == id);
        }
        /// <summary>
        /// Cadastra uma nova consulta 
        /// </summary>
        /// <param name="novaConsulta"></param>
        public void Cadastrar(Consultum novaConsulta)
        {
            //Adiciona uma nova consulta para ser gravada no banco de dados
            ctx.Consulta.Add(novaConsulta);
            //Salva as alterações
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Consultum consultaBuscada = BuscarPorId(id);

            ctx.Consulta.Remove(consultaBuscada);

            ctx.SaveChanges();
        }

        public List<Consultum> ListarTodas()
        {
            return ctx.Consulta.ToList();
        }

        
    }
}
